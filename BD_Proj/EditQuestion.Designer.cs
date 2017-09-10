namespace BD_Proj
{
    partial class EditQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label questionContentLabel;
            System.Windows.Forms.Label questionIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuestion));
            this.qUESTIONSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.qUESTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUIZDataSet = new BD_Proj.QUIZDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qUESTIONSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.questionContentTextBox = new System.Windows.Forms.TextBox();
            this.questionIdTextBox = new System.Windows.Forms.TextBox();
            this.aNSWERSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aNSWERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUESTIONSTableAdapter = new BD_Proj.QUIZDataSetTableAdapters.QUESTIONSTableAdapter();
            this.tableAdapterManager = new BD_Proj.QUIZDataSetTableAdapters.TableAdapterManager();
            this.aNSWERSTableAdapter = new BD_Proj.QUIZDataSetTableAdapters.ANSWERSTableAdapter();
            questionContentLabel = new System.Windows.Forms.Label();
            questionIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qUESTIONSBindingNavigator)).BeginInit();
            this.qUESTIONSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUESTIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSWERSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSWERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionContentLabel
            // 
            questionContentLabel.AutoSize = true;
            questionContentLabel.Location = new System.Drawing.Point(71, 80);
            questionContentLabel.Name = "questionContentLabel";
            questionContentLabel.Size = new System.Drawing.Size(90, 13);
            questionContentLabel.TabIndex = 3;
            questionContentLabel.Text = "question Content:";
            // 
            // questionIdLabel
            // 
            questionIdLabel.AutoSize = true;
            questionIdLabel.Location = new System.Drawing.Point(71, 54);
            questionIdLabel.Name = "questionIdLabel";
            questionIdLabel.Size = new System.Drawing.Size(62, 13);
            questionIdLabel.TabIndex = 1;
            questionIdLabel.Text = "question Id:";
            // 
            // qUESTIONSBindingNavigator
            // 
            this.qUESTIONSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qUESTIONSBindingNavigator.BindingSource = this.qUESTIONSBindingSource;
            this.qUESTIONSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qUESTIONSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qUESTIONSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qUESTIONSBindingNavigatorSaveItem});
            this.qUESTIONSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qUESTIONSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qUESTIONSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qUESTIONSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qUESTIONSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qUESTIONSBindingNavigator.Name = "qUESTIONSBindingNavigator";
            this.qUESTIONSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qUESTIONSBindingNavigator.Size = new System.Drawing.Size(835, 25);
            this.qUESTIONSBindingNavigator.TabIndex = 0;
            this.qUESTIONSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // qUESTIONSBindingSource
            // 
            this.qUESTIONSBindingSource.DataMember = "QUESTIONS";
            this.qUESTIONSBindingSource.DataSource = this.qUIZDataSet;
            // 
            // qUIZDataSet
            // 
            this.qUIZDataSet.DataSetName = "QUIZDataSet";
            this.qUIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.answerUpdateTable);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // qUESTIONSBindingNavigatorSaveItem
            // 
            this.qUESTIONSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qUESTIONSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qUESTIONSBindingNavigatorSaveItem.Image")));
            this.qUESTIONSBindingNavigatorSaveItem.Name = "qUESTIONSBindingNavigatorSaveItem";
            this.qUESTIONSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.qUESTIONSBindingNavigatorSaveItem.Text = "Save Data";
            this.qUESTIONSBindingNavigatorSaveItem.Click += new System.EventHandler(this.qUESTIONSBindingNavigatorSaveItem_Click_1);
            // 
            // questionContentTextBox
            // 
            this.questionContentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUESTIONSBindingSource, "questionContent", true));
            this.questionContentTextBox.Location = new System.Drawing.Point(167, 77);
            this.questionContentTextBox.Name = "questionContentTextBox";
            this.questionContentTextBox.Size = new System.Drawing.Size(383, 20);
            this.questionContentTextBox.TabIndex = 4;
            // 
            // questionIdTextBox
            // 
            this.questionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUESTIONSBindingSource, "questionId", true));
            this.questionIdTextBox.Location = new System.Drawing.Point(167, 51);
            this.questionIdTextBox.Name = "questionIdTextBox";
            this.questionIdTextBox.Size = new System.Drawing.Size(383, 20);
            this.questionIdTextBox.TabIndex = 2;
            // 
            // aNSWERSDataGridView
            // 
            this.aNSWERSDataGridView.AutoGenerateColumns = false;
            this.aNSWERSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aNSWERSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.aNSWERSDataGridView.DataSource = this.aNSWERSBindingSource;
            this.aNSWERSDataGridView.Location = new System.Drawing.Point(74, 127);
            this.aNSWERSDataGridView.Name = "aNSWERSDataGridView";
            this.aNSWERSDataGridView.Size = new System.Drawing.Size(681, 224);
            this.aNSWERSDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "questionId";
            this.dataGridViewTextBoxColumn3.HeaderText = "questionId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "answerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "answerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "answerContent";
            this.dataGridViewTextBoxColumn2.HeaderText = "answerContent";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "correctAnswer";
            this.dataGridViewCheckBoxColumn1.HeaderText = "correctAnswer";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // aNSWERSBindingSource
            // 
            this.aNSWERSBindingSource.DataMember = "ANSWERS";
            this.aNSWERSBindingSource.DataSource = this.qUIZDataSet;
            // 
            // qUESTIONSTableAdapter
            // 
            this.qUESTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANSWERSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QUESTIONSTableAdapter = this.qUESTIONSTableAdapter;
            this.tableAdapterManager.ROLESTableAdapter = null;
            this.tableAdapterManager.SCORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_Proj.QUIZDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            // 
            // aNSWERSTableAdapter
            // 
            this.aNSWERSTableAdapter.ClearBeforeFill = true;
            // 
            // EditQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 361);
            this.Controls.Add(this.aNSWERSDataGridView);
            this.Controls.Add(questionIdLabel);
            this.Controls.Add(this.questionIdTextBox);
            this.Controls.Add(questionContentLabel);
            this.Controls.Add(this.questionContentTextBox);
            this.Controls.Add(this.qUESTIONSBindingNavigator);
            this.Name = "EditQuestion";
            this.Text = "Edytuj pytanie";
            this.Load += new System.EventHandler(this.EditQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUESTIONSBindingNavigator)).EndInit();
            this.qUESTIONSBindingNavigator.ResumeLayout(false);
            this.qUESTIONSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUESTIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSWERSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNSWERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QUIZDataSet qUIZDataSet;
        private System.Windows.Forms.BindingSource qUESTIONSBindingSource;
        private QUIZDataSetTableAdapters.QUESTIONSTableAdapter qUESTIONSTableAdapter;
        private QUIZDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qUESTIONSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qUESTIONSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource aNSWERSBindingSource;
        private QUIZDataSetTableAdapters.ANSWERSTableAdapter aNSWERSTableAdapter;
        private System.Windows.Forms.TextBox questionContentTextBox;
        private System.Windows.Forms.TextBox questionIdTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView aNSWERSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}