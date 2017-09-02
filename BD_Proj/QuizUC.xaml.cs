using System;
using System.Collections.Generic;
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
        private const short questionAmount = 10;
        private short currentQuestion = 0;
        private short score = 0;
        private String[] questions = new String[questionAmount];
        private String[] answers = new String[4];
        private short correctAnswer;
        public QuizUC()
        {
            InitializeComponent();
        }

        private void InitQuestions()
        {
            // questions = pobranie z bazy 10 losowych
            NextQuestion();
        }

        private void UpdateText()
        {
            QuestionTextBox.Text = questions[currentQuestion];
            Answer1Button.Content = answers[0];
            Answer2Button.Content = answers[1];
            Answer3Button.Content = answers[2];
            Answer4Button.Content = answers[3];
        }

        private void NextQuestion()
        {
            if(currentQuestion > questionAmount)
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
