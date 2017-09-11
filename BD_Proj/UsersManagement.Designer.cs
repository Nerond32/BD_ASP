namespace BD_Proj
{
    partial class UsersManagement
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label roleIdLabel;
            System.Windows.Forms.Label scoreIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersManagement));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.qUIZDataSet = new BD_Proj.QUIZDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new BD_Proj.QUIZDataSetTableAdapters.USERSTableAdapter();
            this.tableAdapterManager = new BD_Proj.QUIZDataSetTableAdapters.TableAdapterManager();
            this.uSERSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.uSERSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.roleIdTextBox = new System.Windows.Forms.TextBox();
            this.scoreIdTextBox = new System.Windows.Forms.TextBox();
            this.sCORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCORESTableAdapter = new BD_Proj.QUIZDataSetTableAdapters.SCORESTableAdapter();
            this.sCORESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            roleIdLabel = new System.Windows.Forms.Label();
            scoreIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingNavigator)).BeginInit();
            this.uSERSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(101, 45);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(42, 13);
            userIdLabel.TabIndex = 1;
            userIdLabel.Text = "user Id:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(101, 71);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(101, 97);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // roleIdLabel
            // 
            roleIdLabel.AutoSize = true;
            roleIdLabel.Location = new System.Drawing.Point(101, 123);
            roleIdLabel.Name = "roleIdLabel";
            roleIdLabel.Size = new System.Drawing.Size(39, 13);
            roleIdLabel.TabIndex = 7;
            roleIdLabel.Text = "role Id:";
            // 
            // scoreIdLabel
            // 
            scoreIdLabel.AutoSize = true;
            scoreIdLabel.Location = new System.Drawing.Point(101, 149);
            scoreIdLabel.Name = "scoreIdLabel";
            scoreIdLabel.Size = new System.Drawing.Size(48, 13);
            scoreIdLabel.TabIndex = 9;
            scoreIdLabel.Text = "score Id:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // qUIZDataSet
            // 
            this.qUIZDataSet.DataSetName = "QUIZDataSet";
            this.qUIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.qUIZDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANSWERSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.QUESTIONSTableAdapter = null;
            this.tableAdapterManager.ROLESTableAdapter = null;
            this.tableAdapterManager.SCORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_Proj.QUIZDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = this.uSERSTableAdapter;
            // 
            // uSERSBindingNavigator
            // 
            this.uSERSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uSERSBindingNavigator.BindingSource = this.uSERSBindingSource;
            this.uSERSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uSERSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uSERSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uSERSBindingNavigatorSaveItem});
            this.uSERSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uSERSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uSERSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uSERSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uSERSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uSERSBindingNavigator.Name = "uSERSBindingNavigator";
            this.uSERSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uSERSBindingNavigator.Size = new System.Drawing.Size(344, 25);
            this.uSERSBindingNavigator.TabIndex = 0;
            this.uSERSBindingNavigator.Text = "bindingNavigator1";
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
            // uSERSBindingNavigatorSaveItem
            // 
            this.uSERSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uSERSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uSERSBindingNavigatorSaveItem.Image")));
            this.uSERSBindingNavigatorSaveItem.Name = "uSERSBindingNavigatorSaveItem";
            this.uSERSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uSERSBindingNavigatorSaveItem.Text = "Save Data";
            this.uSERSBindingNavigatorSaveItem.Click += new System.EventHandler(this.uSERSBindingNavigatorSaveItem_Click);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "userId", true));
            this.userIdTextBox.Location = new System.Drawing.Point(162, 42);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "login", true));
            this.loginTextBox.Location = new System.Drawing.Point(162, 68);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(162, 94);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // roleIdTextBox
            // 
            this.roleIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "roleId", true));
            this.roleIdTextBox.Location = new System.Drawing.Point(162, 120);
            this.roleIdTextBox.Name = "roleIdTextBox";
            this.roleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.roleIdTextBox.TabIndex = 8;
            // 
            // scoreIdTextBox
            // 
            this.scoreIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSERSBindingSource, "scoreId", true));
            this.scoreIdTextBox.Location = new System.Drawing.Point(162, 146);
            this.scoreIdTextBox.Name = "scoreIdTextBox";
            this.scoreIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoreIdTextBox.TabIndex = 10;
            this.scoreIdTextBox.TextChanged += new System.EventHandler(this.loadStats);
            // 
            // sCORESBindingSource
            // 
            this.sCORESBindingSource.DataMember = "SCORES";
            this.sCORESBindingSource.DataSource = this.qUIZDataSet;
            // 
            // sCORESTableAdapter
            // 
            this.sCORESTableAdapter.ClearBeforeFill = true;
            // 
            // sCORESDataGridView
            // 
            this.sCORESDataGridView.AutoGenerateColumns = false;
            this.sCORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sCORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sCORESDataGridView.DataSource = this.sCORESBindingSource;
            this.sCORESDataGridView.Location = new System.Drawing.Point(0, 227);
            this.sCORESDataGridView.Name = "sCORESDataGridView";
            this.sCORESDataGridView.Size = new System.Drawing.Size(346, 78);
            this.sCORESDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "scoreId";
            this.dataGridViewTextBoxColumn1.HeaderText = "scoreId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "win";
            this.dataGridViewTextBoxColumn2.HeaderText = "win";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lost";
            this.dataGridViewTextBoxColumn3.HeaderText = "lost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(127, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Statystyki";
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sCORESDataGridView);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(roleIdLabel);
            this.Controls.Add(this.roleIdTextBox);
            this.Controls.Add(scoreIdLabel);
            this.Controls.Add(this.scoreIdTextBox);
            this.Controls.Add(this.uSERSBindingNavigator);
            this.Name = "UsersManagement";
            this.Text = "Użytkownicy";
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qUIZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingNavigator)).EndInit();
            this.uSERSBindingNavigator.ResumeLayout(false);
            this.uSERSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private QUIZDataSet qUIZDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private QUIZDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private QUIZDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uSERSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uSERSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox roleIdTextBox;
        private System.Windows.Forms.TextBox scoreIdTextBox;
        private System.Windows.Forms.BindingSource sCORESBindingSource;
        private QUIZDataSetTableAdapters.SCORESTableAdapter sCORESTableAdapter;
        private System.Windows.Forms.DataGridView sCORESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}