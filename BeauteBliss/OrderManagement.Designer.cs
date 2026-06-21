namespace BeauteBliss
{
    partial class OrderManagement
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
            this.lblorder = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dgvbooking = new System.Windows.Forms.DataGridView();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.gbsearch = new System.Windows.Forms.GroupBox();
            this.gbstatus = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooking)).BeginInit();
            this.gbsearch.SuspendLayout();
            this.gbstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lblorder.Location = new System.Drawing.Point(312, 22);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(322, 38);
            this.lblorder.TabIndex = 2;
            this.lblorder.Text = "ORDER MANAGEMENT";
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Location = new System.Drawing.Point(36, 550);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(115, 42);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(158, 18);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(116, 43);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update Status";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(833, 550);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(115, 42);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dgvbooking
            // 
            this.dgvbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbooking.Location = new System.Drawing.Point(12, 179);
            this.dgvbooking.Name = "dgvbooking";
            this.dgvbooking.RowHeadersWidth = 51;
            this.dgvbooking.RowTemplate.Height = 24;
            this.dgvbooking.Size = new System.Drawing.Size(963, 299);
            this.dgvbooking.TabIndex = 6;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Cancelled"});
            this.cmbstatus.Location = new System.Drawing.Point(6, 29);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(132, 24);
            this.cmbstatus.TabIndex = 7;
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(6, 37);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(194, 22);
            this.tbsearch.TabIndex = 11;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(206, 32);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(85, 34);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // gbsearch
            // 
            this.gbsearch.Controls.Add(this.btnsearch);
            this.gbsearch.Controls.Add(this.tbsearch);
            this.gbsearch.Location = new System.Drawing.Point(71, 83);
            this.gbsearch.Name = "gbsearch";
            this.gbsearch.Size = new System.Drawing.Size(330, 90);
            this.gbsearch.TabIndex = 13;
            this.gbsearch.TabStop = false;
            this.gbsearch.Text = "Search Booking ID : ";
            // 
            // gbstatus
            // 
            this.gbstatus.Controls.Add(this.cmbstatus);
            this.gbstatus.Controls.Add(this.btnupdate);
            this.gbstatus.Location = new System.Drawing.Point(352, 526);
            this.gbstatus.Name = "gbstatus";
            this.gbstatus.Size = new System.Drawing.Size(292, 72);
            this.gbstatus.TabIndex = 14;
            this.gbstatus.TabStop = false;
            this.gbstatus.Text = "Booking Status : ";
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(987, 623);
            this.Controls.Add(this.gbstatus);
            this.Controls.Add(this.gbsearch);
            this.Controls.Add(this.dgvbooking);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.lblorder);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbooking)).EndInit();
            this.gbsearch.ResumeLayout(false);
            this.gbsearch.PerformLayout();
            this.gbstatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dgvbooking;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox gbsearch;
        private System.Windows.Forms.GroupBox gbstatus;
    }
}