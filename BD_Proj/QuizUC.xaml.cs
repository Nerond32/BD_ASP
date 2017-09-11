using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BD_Proj
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class QuizUC : UserControl
    {
        private const short questionAmount = 5;
        private short currentQuestion = 0;
        private short score = 0;
        private DataRow[] questions = new DataRow[questionAmount];
        private DataRow[] answers = new DataRow[4];
        private short correctAnswer;
        private QUIZDataSet quizDS = new QUIZDataSet();
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUIZ.mdf;Integrated Security=True;Connect Timeout=30");
        public QuizUC()
        {
            conn.Open();
            InitializeComponent();
            InitQuestions();
        }

        private void InitQuestions()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM QUESTIONS ORDER BY NEWID()", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable questionsDT = new DataTable();
            sda.Fill(questionsDT);
            int questionsAvailable = questionsDT.Rows.Count;
            if(questionsAvailable < questionAmount)
            {
                FinishQuiz();
                return;
            }
            questions = questionsDT.Select();
            NextQuestion();
        }

        private void UpdateText()
        {
            QuestionTextBox.Text = (String)questions[currentQuestion].ItemArray[1];
            Answer1Button.Content = (String)answers[0].ItemArray[1];
            Answer2Button.Content = (String)answers[1].ItemArray[1];
            Answer3Button.Content = (String)answers[2].ItemArray[1];
            Answer4Button.Content = (String)answers[3].ItemArray[1];
        }

        private void NextQuestion()
        {
            if(currentQuestion >= questionAmount)
            {
                FinishQuiz();
                return;
            }
            int questionId = (int)questions[currentQuestion].ItemArray[0];
            SqlCommand cmd = new SqlCommand("SELECT TOP 4 * FROM ANSWERS WHERE questionId = " + questionId + " ORDER BY NEWID()", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable answersDT = new DataTable();
            sda.Fill(answersDT);
            answers = answersDT.Select();
            for(int i = 0; i < 4; i++)
            {
                if((bool)answers[i].ItemArray[2])
                {
                    correctAnswer = (short)(i + 1);
                }
            }
            Console.WriteLine(correctAnswer);
            UpdateText();
            currentQuestion++;
        }

        private void FinishQuiz()
        {
            SqlCommand cmd = new SqlCommand("UPDATE SCORES  SET win = win + "+ score +"WHERE scoreId = " + MenuUC.loggedUserScoreID, conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE SCORES  SET lost = lost + " + (questionAmount - score) + "WHERE scoreId = " + MenuUC.loggedUserScoreID, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MainWindow.ChangeModeDelegate(2, score);
        }

        private void AbortButton_Click(object sender, RoutedEventArgs e)
        {
            conn.Close();
            MainWindow.ChangeModeDelegate(0, 0);
        }

        private void Answer(short answerNr)
        {
            if(correctAnswer == answerNr)
            {
                score++;
            }
            NextQuestion();
        }
        #region AnswerButtonClicks
        private void Answer1Click(object sender, RoutedEventArgs e)
        {
            Answer(1);
        }

        private void Answer2Click(object sender, RoutedEventArgs e)
        {
            Answer(2);
        }

        private void Answer3Click(object sender, RoutedEventArgs e)
        {
            Answer(3);
        }

        private void Answer4Click(object sender, RoutedEventArgs e)
        {
            Answer(4);
        }
        #endregion
    }
}
