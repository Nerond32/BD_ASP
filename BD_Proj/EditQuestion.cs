﻿using System;
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
            // TODO: This line of code loads data into the 'qUIZDataSet.ANSWERS' table. You can move, or remove it, as needed.
            this.aNSWERSTableAdapter.FillBy1(this.qUIZDataSet.ANSWERS, ((int)(System.Convert.ChangeType(bindingNavigatorPositionItem.Text, typeof(int)))));
            this.qUESTIONSTableAdapter.Fill(this.qUIZDataSet.QUESTIONS);

        }

        private void qUESTIONSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.qUESTIONSBindingSource.EndEdit();
                this.Validate();
               
                this.qUESTIONSTableAdapter.Update(this.qUIZDataSet.QUESTIONS);
                this.aNSWERSTableAdapter.Update(this.qUIZDataSet.ANSWERS);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aNSWERSTableAdapter.FillBy(this.qUIZDataSet.ANSWERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void answerUpdateTable(object sender, EventArgs e)
        {
            this.aNSWERSTableAdapter.FillBy1(this.qUIZDataSet.ANSWERS, ((int)(System.Convert.ChangeType(bindingNavigatorPositionItem.Text, typeof(int)))));
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();      
            this.aNSWERSTableAdapter.Update(this.qUIZDataSet.ANSWERS);
        }
    }
}
