namespace BeauteBliss
{
    partial class AdminDashboard
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
            this.lbldashboard = new System.Windows.Forms.Label();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.buttonsales = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.btnstaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lbldashboard.Location = new System.Drawing.Point(281, 83);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(300, 38);
            this.lbldashboard.TabIndex = 1;
            this.lbldashboard.Text = "ADMIN DASHBOARD";
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.ForeColor = System.Drawing.Color.White;
            this.btncustomer.Location = new System.Drawing.Point(258, 172);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(340, 50);
            this.btncustomer.TabIndex = 2;
            this.btncustomer.Text = "Customer Management";
            this.btncustomer.UseVisualStyleBackColor = false;
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.Color.White;
            this.btnorder.Location = new System.Drawing.Point(258, 242);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(340, 50);
            this.btnorder.TabIndex = 3;
            this.btnorder.Text = "Order Management";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // buttonsales
            // 
            this.buttonsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.buttonsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsales.ForeColor = System.Drawing.Color.White;
            this.buttonsales.Location = new System.Drawing.Point(258, 386);
            this.buttonsales.Name = "buttonsales";
            this.buttonsales.Size = new System.Drawing.Size(340, 50);
            this.buttonsales.TabIndex = 4;
            this.buttonsales.Text = "Sales Report";
            this.buttonsales.UseVisualStyleBackColor = false;
            this.buttonsales.Click += new System.EventHandler(this.buttonsales_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.Color.White;
            this.buttonlogout.Location = new System.Drawing.Point(258, 466);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(340, 50);
            this.buttonlogout.TabIndex = 5;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // btnstaff
            // 
            this.btnstaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnstaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaff.ForeColor = System.Drawing.Color.White;
            this.btnstaff.Location = new System.Drawing.Point(260, 311);
            this.btnstaff.Name = "btnstaff";
            this.btnstaff.Size = new System.Drawing.Size(340, 50);
            this.btnstaff.TabIndex = 6;
            this.btnstaff.Text = "Staff Management";
            this.btnstaff.UseVisualStyleBackColor = false;
            this.btnstaff.Click += new System.EventHandler(this.btnstaff_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(870, 563);
            this.Controls.Add(this.btnstaff);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonsales);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.lbldashboard);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button buttonsales;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button btnstaff;
    }
}