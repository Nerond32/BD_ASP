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
    public partial class EditQuestion : Form
    {
        public EditQuestion()
        {
            InitializeComponent();
        }
        private void EditQuestion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUIZDataSet.QUESTIONS' table. You can move, or remove it, as needed.
            this.qUESTIONSTableAdapter.Fill(this.qUIZDataSet.QUESTIONS);

        }
    }
}
