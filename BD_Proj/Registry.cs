using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Proj
{
    public partial class Registry : Form
    {
        SqlConnection conn;
        public Registry()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUIZ.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String scoreId = "1", userId = "1";

            if (loginTextBox.Text.ToString() != "" && passwordTextBox.Text.ToString() != "")
            {
                String queryScoreId = "SELECT TOP 1 scoreId FROM SCORES ORDER BY scoreId DESC";
                SqlCommand commandScoreId = new SqlCommand(queryScoreId, conn);

                SqlDataReader reader = commandScoreId.ExecuteReader();
                while (reader.Read())
                {
                    scoreId = reader[0].ToString();
                }
                reader.Close();

                String queryUserId = "SELECT TOP 1 userId FROM USERS ORDER BY scoreId DESC";
                SqlCommand commandUserId = new SqlCommand(queryUserId, conn);

                SqlDataReader readerUserid = commandUserId.ExecuteReader();
                while (readerUserid.Read())
                {
                    userId = readerUserid[0].ToString();
                }
                readerUserid.Close();

                scoreId = (int.Parse(scoreId) + 1).ToString();
                userId = (int.Parse(userId) + 1).ToString();
                String queryScores = "INSERT INTO SCORES VALUES (" + scoreId + ",0,0);" + "INSERT INTO USERS VALUES (" + userId + "," + "'" + loginTextBox.Text.ToString() + "'" + "," + "'" + passwordTextBox.Text.ToString() + "'" + "," + 2 + "," + scoreId + ")";
                SqlCommand command1 = new SqlCommand(queryScores, conn);
                command1.ExecuteNonQuery();

                this.Close();
            }
            else {
                MessageBox.Show("Login lub hasło puste!");
            }

          }

        private void closeConnection(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
