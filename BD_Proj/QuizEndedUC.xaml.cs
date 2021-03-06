﻿using System;
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
    /// Interaction logic for QuizEnded.xaml
    /// </summary>
    public partial class QuizEndedUC : UserControl
    {
        public QuizEndedUC(short score)
        {
            InitializeComponent();
            ScoreLabel.Content = "Twój wynik to " + score + " na 5";
        }

        private void PlayAgainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeModeDelegate(1,0);
        }

        private void HighscoresButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeModeDelegate(3,0);
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeModeDelegate(0,0);
        }
    }
}
