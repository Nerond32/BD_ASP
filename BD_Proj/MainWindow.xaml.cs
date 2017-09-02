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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public delegate void ChangeModeDelegate(short mode);
    public partial class MainWindow : Window
    {
        private static ChangeModeDelegate changeMode = ChangeMode;
        public static ChangeModeDelegate ChangeModeDelegate { get { return changeMode; } set { changeMode = value; } }
        private static MainWindow mw;
        public MainWindow()
        {
            InitializeComponent();
            MenuUC menuUC = new MenuUC();
            mainSP.Children.Add(menuUC);
            mw = this;
        }

        private static void ChangeMode(short mode)
        {
            mw.mainSP.Children.RemoveAt(0);
            switch(mode)
            {
                case 0:
                {
                    MenuUC menuUC = new MenuUC();
                    mw.mainSP.Children.Add(menuUC);
                    break;
                }
                case 1:
                {   
                    QuizUC quizUC = new QuizUC();
                    mw.mainSP.Children.Add(quizUC);
                    break;
                }
                case 2:
                {
                    QuizEndedUC quizEndedUC = new QuizEndedUC();
                    mw.mainSP.Children.Add(quizEndedUC);
                    break;
                }
            }
        }
    }
}
