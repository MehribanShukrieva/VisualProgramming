﻿namespace Chart_Example_2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partiNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyoranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oYDataSet = new Chart_Example_2.OYDataSet();
            this.oYTableAdapter = new Chart_Example_2.OYDataSetTableAdapters.OYTableAdapter();
            this.oyDataSet1 = new Chart_Example_2.OYDataSet();
            this.chartDataSet = new Chart_Example_2.ChartDataSet();
            this.chartDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.chartDataSet1 = new Chart_Example_2.ChartDataSet();
            this.chartDataSet2 = new Chart_Example_2.ChartDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(69, 30);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "OY";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "ChartDataSet";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(637, 369);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(579, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partiNameDataGridViewTextBoxColumn,
            this.oyoranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(789, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(323, 284);
            this.dataGridView1.TabIndex = 2;
            // 
            // partiNameDataGridViewTextBoxColumn
            // 
            this.partiNameDataGridViewTextBoxColumn.DataPropertyName = "Parti_Name";
            this.partiNameDataGridViewTextBoxColumn.HeaderText = "Parti_Name";
            this.partiNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partiNameDataGridViewTextBoxColumn.Name = "partiNameDataGridViewTextBoxColumn";
            this.partiNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // oyoranDataGridViewTextBoxColumn
            // 
            this.oyoranDataGridViewTextBoxColumn.DataPropertyName = "Oy_oran";
            this.oyoranDataGridViewTextBoxColumn.HeaderText = "Oy_oran";
            this.oyoranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oyoranDataGridViewTextBoxColumn.Name = "oyoranDataGridViewTextBoxColumn";
            this.oyoranDataGridViewTextBoxColumn.Width = 125;
            // 
            // oYBindingSource
            // 
            this.oYBindingSource.DataMember = "OY";
            this.oYBindingSource.DataSource = this.oYDataSet;
            // 
            // oYDataSet
            // 
            this.oYDataSet.DataSetName = "OYDataSet";
            this.oYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oYTableAdapter
            // 
            this.oYTableAdapter.ClearBeforeFill = true;
            // 
            // oyDataSet1
            // 
            this.oyDataSet1.DataSetName = "OYDataSet";
            this.oyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartDataSet
            // 
            this.chartDataSet.DataSetName = "ChartDataSet";
            this.chartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartDataSetBindingSource
            // 
            this.chartDataSetBindingSource.DataSource = this.chartDataSet;
            this.chartDataSetBindingSource.Position = 0;
            // 
            // chartDataSetBindingSource1
            // 
            this.chartDataSetBindingSource1.DataSource = this.chartDataSet;
            this.chartDataSetBindingSource1.Position = 0;
            // 
            // chartDataSetBindingSource2
            // 
            this.chartDataSetBindingSource2.DataSource = this.chartDataSet;
            this.chartDataSetBindingSource2.Position = 0;
            // 
            // chartDataSet1
            // 
            this.chartDataSet1.DataSetName = "ChartDataSet";
            this.chartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartDataSet2
            // 
            this.chartDataSet2.DataSetName = "ChartDataSet";
            this.chartDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource chartDataSetBindingSource;
        private ChartDataSet chartDataSet;
        private System.Windows.Forms.BindingSource chartDataSetBindingSource2;
        private System.Windows.Forms.BindingSource chartDataSetBindingSource1;
        private OYDataSet oYDataSet;
        private System.Windows.Forms.BindingSource oYBindingSource;
        private OYDataSetTableAdapters.OYTableAdapter oYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partiNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyoranDataGridViewTextBoxColumn;
        private ChartDataSet chartDataSet1;
        private ChartDataSet chartDataSet2;
        private OYDataSet oyDataSet1;
    }
}

