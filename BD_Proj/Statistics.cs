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
using System.Windows.Forms.DataVisualization.Charting;

namespace BD_Proj
{
    public partial class Statistics : Form
    {
        SqlConnection conn;
        public Statistics()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\QUIZ.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            string[] seriesArray = { "Wygrane", "Przegrane" };
            int[] pointsArray = { 1, 2 };
            String query = "SELECT * FROM SCORES WHERE scoreId = (SELECT scoreId FROM USERS WHERE userId ="+ 1 +")"; 
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               pointsArray[0] = int.Parse(reader[1].ToString());
               pointsArray[1] = int.Parse(reader[2].ToString());
            }
            chart2.Series.Clear();

            // Set palette.
            this.chart2.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart2.Titles.Add("Statistics");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = chart2.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
            }

        }
    }
}
