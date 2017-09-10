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
using System.Windows.Shapes;

namespace BD_Proj
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addQuestion(object sender, RoutedEventArgs e)
        {
            UsersManagement addQuestionForm = new UsersManagement();
            addQuestionForm.Show();
        }

        private void edtiQuestion(object sender, RoutedEventArgs e)
        {
            EditQuestion editQuestionForm = new EditQuestion();
            editQuestionForm.Show();
        }
    }
}
