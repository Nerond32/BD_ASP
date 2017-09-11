using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
    public partial class MenuUC : System.Windows.Controls.UserControl
    {
        private QUIZDataSet quizDS = new QUIZDataSet();
        private DataRow[] answers = new DataRow[1];
        public static int loggedUserID = -1;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUIZ.mdf;Integrated Security=True;Connect Timeout=30");
        public MenuUC()
        {
            conn.Open();
            InitializeComponent();
            getConnection();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (loggedUserID != -1)
            {
                MainWindow.ChangeModeDelegate(1, 0);
            }
            else
            {
                System.Windows.MessageBox.Show("Tylko zalogowani użytkownicy mogą grać!");
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loggedUserID == -1)
            {
                string username = "username";
                string password = "password";
                ShowInputDialog(ref username, ref password);
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM USERS WHERE login = @username AND password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable answersDT = new DataTable();
                sda.Fill(answersDT);
                answers = answersDT.Select();
                try
                {
                    loggedUserID = (int)answers[0].ItemArray[0];
                    System.Windows.MessageBox.Show("Zalogowano pomyślnie");
                    LoginButton.Content = "Wyloguj";
                }
                catch (Exception exception)
                {
                    System.Windows.MessageBox.Show("Niepoprawne dane logowania!");
                }
            }
            else
            {
                loggedUserID = -1;
                LoginButton.Content = "Zaloguj";
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AdminPanelButton_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM USERS WHERE userId = " + loggedUserID, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable currentUserDT = new DataTable();
            sda.Fill(currentUserDT);
            DataRow[] currentUser = new DataRow[1];
            currentUser = currentUserDT.Select();
            try
            {
                if ((int)currentUser[0].ItemArray[4] == 1)
                {
                    PanelAdmin admin = new PanelAdmin();
                    admin.Show();
                }
                else
                {
                    System.Windows.MessageBox.Show("Brak dostępu!");
                }
            }
            catch(Exception exc)
            {
                System.Windows.MessageBox.Show("Brak dostępu!");
            }
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
    private static DialogResult ShowInputDialog(ref string username, ref string password)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 150);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Login";
            System.Windows.Forms.Label usernameLabel = new System.Windows.Forms.Label();
            usernameLabel.Text = "Username:";
            usernameLabel.Location = new System.Drawing.Point(5, 5);
            System.Windows.Forms.Label passwordLabel = new System.Windows.Forms.Label();
            passwordLabel.Text = "Password:";
            passwordLabel.Location = new System.Drawing.Point(5, 65);
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 35);
            textBox.Text = username;
            
            System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
            textBox2.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox2.Location = new System.Drawing.Point(5, 95);
            textBox2.Text = password;
            textBox2.UseSystemPasswordChar = true;

            inputBox.Controls.Add(usernameLabel);
            inputBox.Controls.Add(passwordLabel);
            inputBox.Controls.Add(textBox);
            inputBox.Controls.Add(textBox2);
            
            System.Windows.Forms.Button okButton = new System.Windows.Forms.Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(5, 120);
            inputBox.Controls.Add(okButton);

            System.Windows.Forms.Button cancelButton = new System.Windows.Forms.Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
           cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(85, 120);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            username = textBox.Text;
            password = textBox2.Text;
            return result;
        }
}
}
