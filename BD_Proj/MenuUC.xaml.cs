using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for MenuUC.xaml
    /// </summary>
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();
            getConnection();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ChangeModeDelegate(1, 0);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AdminPanelButton_Click(object sender, RoutedEventArgs e)
        {
            PanelAdmin admin = new PanelAdmin();
            admin.Show();
        }

        public static void getConnection()
        {
            
            try
            {
                Console.WriteLine("Start Connection");
                SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\BD_ASP\\BD_Proj\\QUIZ.mdf; Integrated Security = True; Connect Timeout = 30");
                con.Open();
               
                SqlCommand commandIns = con.CreateCommand();
                commandIns.Connection = con;
                //commandIns.CommandText = "insert into ANSWERS values (1,'23',1,1) ,(2,'20',0,1), (3,'lama',0,1), (4,'100',0,1)";
               // int rowInserted = commandIns.ExecuteNonQuery();
                //Console.WriteLine("WSTAWIONO : " + rowInserted + " wiersze\n\n");
                
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Błąd połączenia: " + e.Message);
            }
            finally
            {

                Console.WriteLine("Stop Connection");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Statistics form = new Statistics();
            form.Show();
        }
    }
}
