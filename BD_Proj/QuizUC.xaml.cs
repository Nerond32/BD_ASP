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
        private SqlDataAdapter adapter;
        public QuizUC()
        {
            InitializeComponent();
            InitQuestions();
        }

        private void InitQuestions()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUIZ.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 5 * FROM QUESTIONS ORDER BY NEWID()", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable questionsDT = new DataTable();
            sda.Fill(questionsDT);
            conn.Close();
            int questionsAvailable = questionsDT.Rows.Count;
            if(questionsAvailable < questionAmount)
            {
                // błąd bo za mało pytań w bazie
            }
            questions = questionsDT.Select();
            /*QuestionTextBox.Text = (from DataRow dr in questionsDT.Rows
                                    where (int)dr["questionId"] == 1
                                    select (string)dr["questionContent"]).FirstOrDefault();*/
            //QuestionTextBox.Text = "Gówno";
            //DataTable questionsDT = quizDS.Tables["Questions"];
            //var foundRows = questionsDT.Select();
            //var query = 
            // questions = pobranie z bazy 10 losowych
            NextQuestion();
        }

        private void UpdateText()
        {
            QuestionTextBox.Text = (String)questions[currentQuestion].ItemArray[1];
            Answer1Button.Content = answers[0];
            Answer2Button.Content = answers[1];
            Answer3Button.Content = answers[2];
            Answer4Button.Content = answers[3];
        }

        private void NextQuestion()
        {
            if(currentQuestion >= questionAmount)
            {
                FinishQuiz();
                return;
            }
            // answers = pobranie z bazy 4 odpowiedzi w LOSOWEJ kolejoności
            // correctAnswer = pozycja dobrej odpowiedzi
            UpdateText();
            currentQuestion++;
        }

        private void FinishQuiz()
        {
            MainWindow.ChangeModeDelegate(2);
        }

        private void AbortButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeModeDelegate(0);
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
