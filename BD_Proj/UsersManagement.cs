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
            // TODO: This line of code loads data into the 'qUIZDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.qUIZDataSet.USERS);

        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                try
                {
                    this.uSERSBindingSource.EndEdit();
                    this.Validate();
                    this.uSERSTableAdapter.Update(this.qUIZDataSet.USERS);
                    MessageBox.Show("Successful");
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Failed");
                }
        }
    }
}
