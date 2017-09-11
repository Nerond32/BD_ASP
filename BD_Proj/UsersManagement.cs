using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Proj
{
    public partial class UsersManagement : Form
    {
        public UsersManagement()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUIZDataSet.SCORES' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qUIZDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.qUIZDataSet.USERS);

        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                try
                {
                    this.uSERSBindingSource.EndEdit();
                    this.sCORESBindingSource.EndEdit();
                    this.Validate();
                    this.sCORESTableAdapter.Update(this.qUIZDataSet.SCORES);
                    this.uSERSTableAdapter.Update(this.qUIZDataSet.USERS);
                    MessageBox.Show("Successful");
                }
                catch (System.Exception blad)
                {
                    MessageBox.Show("Failed" + blad);
                }
        }

        private void loadStats(object sender, EventArgs e)
        {
            if (scoreIdTextBox.Text == "")
            {
                scoreIdTextBox.Text = "100";
            }
            this.sCORESTableAdapter.FillById(this.qUIZDataSet.SCORES, ((int)(System.Convert.ChangeType(scoreIdTextBox.Text, typeof(int)))));
        }
    }
}
