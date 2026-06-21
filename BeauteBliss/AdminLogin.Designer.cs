namespace BeauteBliss
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.cbpassword = new System.Windows.Forms.CheckBox();
            this.pbadmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lbllogin.Location = new System.Drawing.Point(551, 91);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(209, 38);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "ADMIN LOGIN";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(441, 198);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(70, 16);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(441, 251);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(528, 366);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(251, 45);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(519, 196);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(258, 22);
            this.tbusername.TabIndex = 4;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(519, 248);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(258, 22);
            this.tbpassword.TabIndex = 5;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // cbpassword
            // 
            this.cbpassword.AutoSize = true;
            this.cbpassword.Location = new System.Drawing.Point(520, 289);
            this.cbpassword.Name = "cbpassword";
            this.cbpassword.Size = new System.Drawing.Size(125, 20);
            this.cbpassword.TabIndex = 6;
            this.cbpassword.Text = "Show Password";
            this.cbpassword.UseVisualStyleBackColor = true;
            this.cbpassword.CheckedChanged += new System.EventHandler(this.cbpassword_CheckedChanged);
            // 
            // pbadmin
            // 
            this.pbadmin.Image = ((System.Drawing.Image)(resources.GetObject("pbadmin.Image")));
            this.pbadmin.Location = new System.Drawing.Point(33, 103);
            this.pbadmin.Name = "pbadmin";
            this.pbadmin.Size = new System.Drawing.Size(364, 332);
            this.pbadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbadmin.TabIndex = 7;
            this.pbadmin.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(857, 514);
            this.Controls.Add(this.pbadmin);
            this.Controls.Add(this.cbpassword);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.CheckBox cbpassword;
        private System.Windows.Forms.PictureBox pbadmin;
    }
}