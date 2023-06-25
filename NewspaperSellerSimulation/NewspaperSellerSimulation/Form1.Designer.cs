using NewspaperSellerTesting;
using System;

namespace NewspaperSellerSimulation
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
        public string TestCaseName;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combTestCase.SelectedIndex == 0)
            {
                TestCaseName = Constants.FileNames.TestCase1;
                TestCasePath = "C:/TestCases/TestCase1.txt";
            }
            else if (combTestCase.SelectedIndex == 1)
            {
                TestCaseName = Constants.FileNames.TestCase2;
                TestCasePath = "C:/TestCases/TestCase2.txt";
            }

            else if (combTestCase.SelectedIndex == 2)
            {
                TestCaseName = Constants.FileNames.TestCase3;
                TestCasePath = "C:/TestCases/TestCase3.txt";
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnauto = new System.Windows.Forms.Button();
            this.performance = new System.Windows.Forms.Button();
            this.simulationCaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomNewsDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newsDayTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDemandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyNetProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combTestCase = new System.Windows.Forms.ComboBox();
            this.TestCases = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simulationCaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnauto
            // 
            this.btnauto.Location = new System.Drawing.Point(1087, 234);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(108, 40);
            this.btnauto.TabIndex = 1;
            this.btnauto.Text = "Simulate";
            this.btnauto.UseVisualStyleBackColor = true;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // performance
            // 
            this.performance.Location = new System.Drawing.Point(1047, 354);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(173, 46);
            this.performance.TabIndex = 5;
            this.performance.Text = "performance Measure";
            this.performance.UseVisualStyleBackColor = true;
            this.performance.Click += new System.EventHandler(this.performance_Click);
            // 
            // simulationCaseBindingSource
            // 
            this.simulationCaseBindingSource.DataSource = typeof(NewspaperSellerModels.SimulationCase);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayNoDataGridViewTextBoxColumn,
            this.randomNewsDayTypeDataGridViewTextBoxColumn,
            this.newsDayTypeDataGridViewTextBoxColumn,
            this.randomDemandDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.dailyCostDataGridViewTextBoxColumn,
            this.salesProfitDataGridViewTextBoxColumn,
            this.lostProfitDataGridViewTextBoxColumn,
            this.scrapProfitDataGridViewTextBoxColumn,
            this.dailyNetProfitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulationCaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1041, 469);
            this.dataGridView1.TabIndex = 6;
            // 
            // dayNoDataGridViewTextBoxColumn
            // 
            this.dayNoDataGridViewTextBoxColumn.DataPropertyName = "DayNo";
            this.dayNoDataGridViewTextBoxColumn.HeaderText = "DayNo";
            this.dayNoDataGridViewTextBoxColumn.Name = "dayNoDataGridViewTextBoxColumn";
            // 
            // randomNewsDayTypeDataGridViewTextBoxColumn
            // 
            this.randomNewsDayTypeDataGridViewTextBoxColumn.DataPropertyName = "RandomNewsDayType";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.HeaderText = "RandomNewsDayType";
            this.randomNewsDayTypeDataGridViewTextBoxColumn.Name = "randomNewsDayTypeDataGridViewTextBoxColumn";
            // 
            // newsDayTypeDataGridViewTextBoxColumn
            // 
            this.newsDayTypeDataGridViewTextBoxColumn.DataPropertyName = "NewsDayType";
            this.newsDayTypeDataGridViewTextBoxColumn.HeaderText = "NewsDayType";
            this.newsDayTypeDataGridViewTextBoxColumn.Name = "newsDayTypeDataGridViewTextBoxColumn";
            // 
            // randomDemandDataGridViewTextBoxColumn
            // 
            this.randomDemandDataGridViewTextBoxColumn.DataPropertyName = "RandomDemand";
            this.randomDemandDataGridViewTextBoxColumn.HeaderText = "RandomDemand";
            this.randomDemandDataGridViewTextBoxColumn.Name = "randomDemandDataGridViewTextBoxColumn";
            // 
            // demandDataGridViewTextBoxColumn
            // 
            this.demandDataGridViewTextBoxColumn.DataPropertyName = "Demand";
            this.demandDataGridViewTextBoxColumn.HeaderText = "Demand";
            this.demandDataGridViewTextBoxColumn.Name = "demandDataGridViewTextBoxColumn";
            // 
            // dailyCostDataGridViewTextBoxColumn
            // 
            this.dailyCostDataGridViewTextBoxColumn.DataPropertyName = "DailyCost";
            this.dailyCostDataGridViewTextBoxColumn.HeaderText = "DailyCost";
            this.dailyCostDataGridViewTextBoxColumn.Name = "dailyCostDataGridViewTextBoxColumn";
            // 
            // salesProfitDataGridViewTextBoxColumn
            // 
            this.salesProfitDataGridViewTextBoxColumn.DataPropertyName = "SalesProfit";
            this.salesProfitDataGridViewTextBoxColumn.HeaderText = "SalesProfit";
            this.salesProfitDataGridViewTextBoxColumn.Name = "salesProfitDataGridViewTextBoxColumn";
            // 
            // lostProfitDataGridViewTextBoxColumn
            // 
            this.lostProfitDataGridViewTextBoxColumn.DataPropertyName = "LostProfit";
            this.lostProfitDataGridViewTextBoxColumn.HeaderText = "LostProfit";
            this.lostProfitDataGridViewTextBoxColumn.Name = "lostProfitDataGridViewTextBoxColumn";
            // 
            // scrapProfitDataGridViewTextBoxColumn
            // 
            this.scrapProfitDataGridViewTextBoxColumn.DataPropertyName = "ScrapProfit";
            this.scrapProfitDataGridViewTextBoxColumn.HeaderText = "ScrapProfit";
            this.scrapProfitDataGridViewTextBoxColumn.Name = "scrapProfitDataGridViewTextBoxColumn";
            // 
            // dailyNetProfitDataGridViewTextBoxColumn
            // 
            this.dailyNetProfitDataGridViewTextBoxColumn.DataPropertyName = "DailyNetProfit";
            this.dailyNetProfitDataGridViewTextBoxColumn.HeaderText = "DailyNetProfit";
            this.dailyNetProfitDataGridViewTextBoxColumn.Name = "dailyNetProfitDataGridViewTextBoxColumn";
            // 
            // combTestCase
            // 
            this.combTestCase.FormattingEnabled = true;
            this.combTestCase.Items.AddRange(new object[] {
            "TestCase 1",
            "TestCase 2",
            "Testcase 3"});
            this.combTestCase.Location = new System.Drawing.Point(1066, 176);
            this.combTestCase.Name = "combTestCase";
            this.combTestCase.Size = new System.Drawing.Size(139, 21);
            this.combTestCase.TabIndex = 7;
            this.combTestCase.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TestCases
            // 
            this.TestCases.AutoSize = true;
            this.TestCases.Location = new System.Drawing.Point(1110, 142);
            this.TestCases.Name = "TestCases";
            this.TestCases.Size = new System.Drawing.Size(57, 13);
            this.TestCases.TabIndex = 8;
            this.TestCases.Text = "TestCases";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 494);
            this.Controls.Add(this.TestCases);
            this.Controls.Add(this.combTestCase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.performance);
            this.Controls.Add(this.btnauto);
            this.Name = "Form1";
            this.Text = "Newspaper Ststem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulationCaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnauto;
        private System.Windows.Forms.Button performance;
        private System.Windows.Forms.BindingSource simulationCaseBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomNewsDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newsDayTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDemandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyNetProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox combTestCase;
        private System.Windows.Forms.Label TestCases;
    }
}