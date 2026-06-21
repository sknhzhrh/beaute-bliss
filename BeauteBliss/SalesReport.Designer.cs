namespace BeauteBliss
{
    partial class SalesReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblsales = new System.Windows.Forms.Label();
            this.lbltotalsales = new System.Windows.Forms.Label();
            this.lbltotalbookings = new System.Windows.Forms.Label();
            this.btngenerate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.chartsales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.panelsales = new System.Windows.Forms.Panel();
            this.lblsalestitle = new System.Windows.Forms.Label();
            this.panelbooking = new System.Windows.Forms.Panel();
            this.lblbookingtitle = new System.Windows.Forms.Label();
            this.chartcategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartsales)).BeginInit();
            this.panelsales.SuspendLayout();
            this.panelbooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsales
            // 
            this.lblsales.AutoSize = true;
            this.lblsales.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lblsales.Location = new System.Drawing.Point(391, 19);
            this.lblsales.Name = "lblsales";
            this.lblsales.Size = new System.Drawing.Size(210, 38);
            this.lblsales.TabIndex = 3;
            this.lblsales.Text = "SALES REPORT";
            // 
            // lbltotalsales
            // 
            this.lbltotalsales.AutoSize = true;
            this.lbltotalsales.Location = new System.Drawing.Point(79, 46);
            this.lbltotalsales.Name = "lbltotalsales";
            this.lbltotalsales.Size = new System.Drawing.Size(55, 16);
            this.lbltotalsales.TabIndex = 5;
            this.lbltotalsales.Text = "RM 0.00";
            // 
            // lbltotalbookings
            // 
            this.lbltotalbookings.AutoSize = true;
            this.lbltotalbookings.Location = new System.Drawing.Point(104, 58);
            this.lbltotalbookings.Name = "lbltotalbookings";
            this.lbltotalbookings.Size = new System.Drawing.Size(14, 16);
            this.lbltotalbookings.TabIndex = 7;
            this.lbltotalbookings.Text = "0";
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.ForeColor = System.Drawing.Color.White;
            this.btngenerate.Location = new System.Drawing.Point(66, 161);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(120, 44);
            this.btngenerate.TabIndex = 8;
            this.btngenerate.Text = "Generate Report";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(834, 642);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(132, 46);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // chartsales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartsales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartsales.Legends.Add(legend1);
            this.chartsales.Location = new System.Drawing.Point(37, 371);
            this.chartsales.Name = "chartsales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartsales.Series.Add(series1);
            this.chartsales.Size = new System.Drawing.Size(342, 307);
            this.chartsales.TabIndex = 10;
            this.chartsales.Text = "chart1";
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(63, 87);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(72, 16);
            this.lblstart.TabIndex = 11;
            this.lblstart.Text = "Start Date :";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(63, 124);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(69, 16);
            this.lblend.TabIndex = 12;
            this.lblend.Text = "End Date :";
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(141, 87);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(256, 22);
            this.dtpstart.TabIndex = 13;
            // 
            // dtpend
            // 
            this.dtpend.Location = new System.Drawing.Point(141, 121);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(256, 22);
            this.dtpend.TabIndex = 14;
            // 
            // panelsales
            // 
            this.panelsales.BackColor = System.Drawing.Color.White;
            this.panelsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelsales.Controls.Add(this.lblsalestitle);
            this.panelsales.Controls.Add(this.lbltotalsales);
            this.panelsales.Location = new System.Drawing.Point(102, 251);
            this.panelsales.Name = "panelsales";
            this.panelsales.Size = new System.Drawing.Size(220, 100);
            this.panelsales.TabIndex = 15;
            // 
            // lblsalestitle
            // 
            this.lblsalestitle.AutoSize = true;
            this.lblsalestitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalestitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lblsalestitle.Location = new System.Drawing.Point(46, 10);
            this.lblsalestitle.Name = "lblsalestitle";
            this.lblsalestitle.Size = new System.Drawing.Size(124, 25);
            this.lblsalestitle.TabIndex = 0;
            this.lblsalestitle.Text = "TOTAL SALES";
            // 
            // panelbooking
            // 
            this.panelbooking.BackColor = System.Drawing.Color.White;
            this.panelbooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbooking.Controls.Add(this.lblbookingtitle);
            this.panelbooking.Controls.Add(this.lbltotalbookings);
            this.panelbooking.Location = new System.Drawing.Point(482, 251);
            this.panelbooking.Name = "panelbooking";
            this.panelbooking.Size = new System.Drawing.Size(220, 100);
            this.panelbooking.TabIndex = 16;
            // 
            // lblbookingtitle
            // 
            this.lblbookingtitle.AutoSize = true;
            this.lblbookingtitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lblbookingtitle.Location = new System.Drawing.Point(28, 9);
            this.lblbookingtitle.Name = "lblbookingtitle";
            this.lblbookingtitle.Size = new System.Drawing.Size(167, 25);
            this.lblbookingtitle.TabIndex = 1;
            this.lblbookingtitle.Text = "TOTAL BOOKINGS";
            // 
            // chartcategory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartcategory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartcategory.Legends.Add(legend2);
            this.chartcategory.Location = new System.Drawing.Point(419, 371);
            this.chartcategory.Name = "chartcategory";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartcategory.Series.Add(series2);
            this.chartcategory.Size = new System.Drawing.Size(373, 307);
            this.chartcategory.TabIndex = 17;
            this.chartcategory.Text = "chart1";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(988, 700);
            this.Controls.Add(this.chartcategory);
            this.Controls.Add(this.panelbooking);
            this.Controls.Add(this.panelsales);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.chartsales);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.lblsales);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.chartsales)).EndInit();
            this.panelsales.ResumeLayout(false);
            this.panelsales.PerformLayout();
            this.panelbooking.ResumeLayout(false);
            this.panelbooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsales;
        private System.Windows.Forms.Label lbltotalsales;
        private System.Windows.Forms.Label lbltotalbookings;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsales;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Panel panelsales;
        private System.Windows.Forms.Panel panelbooking;
        private System.Windows.Forms.Label lblsalestitle;
        private System.Windows.Forms.Label lblbookingtitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartcategory;
    }
}