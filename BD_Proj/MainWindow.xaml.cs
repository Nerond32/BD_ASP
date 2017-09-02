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
    public delegate void ChangeModeDelegate();
    public partial class MainWindow : Window
    {
        private bool isGameStarted = false;
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

        private static void ChangeMode()
        {
            mw.mainSP.Children.RemoveAt(0);
            if (mw.isGameStarted)
            {
                QuizUC quizUC = new QuizUC();
                mw.mainSP.Children.Add(quizUC);
            }
            else
            {
                MenuUC menuUC = new MenuUC();
                mw.mainSP.Children.Add(menuUC);
            }
            mw.isGameStarted = !mw.isGameStarted;
        }
    }
}
