namespace BD_Proj
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sCORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUIZDataSet = new BD_Proj.QUIZDataSet();
            this.sCORESTableAdapter = new BD_Proj.QUIZDataSetTableAdapters.SCORESTableAdapter();
            this.sCORESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(12, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(345, 322);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // sCORESBindingSource
            // 
            this.sCORESBindingSource.DataMember = "SCORES";
            this.sCORESBindingSource.DataSource = this.qUIZDataSet;
            // 
            // qUIZDataSet
            // 
            this.qUIZDataSet.DataSetName = "QUIZDataSet";
            this.qUIZDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sCORESTableAdapter
            // 
            this.sCORESTableAdapter.ClearBeforeFill = true;
            // 
            // sCORESBindingSource1
            // 
            this.sCORESBindingSource1.DataMember = "SCORES";
            this.sCORESBindingSource1.DataSource = this.qUIZDataSet;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 326);
            this.Controls.Add(this.chart2);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUIZDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCORESBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private QUIZDataSet qUIZDataSet;
        private System.Windows.Forms.BindingSource sCORESBindingSource;
        private QUIZDataSetTableAdapters.SCORESTableAdapter sCORESTableAdapter;
        private System.Windows.Forms.BindingSource sCORESBindingSource1;
    }
}