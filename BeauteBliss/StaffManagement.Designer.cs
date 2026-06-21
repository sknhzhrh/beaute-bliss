namespace BeauteBliss
{
    partial class StaffManagement
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
            this.lblstaff = new System.Windows.Forms.Label();
            this.lblstaffname = new System.Windows.Forms.Label();
            this.lblstaffemail = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.lblstaffphone = new System.Windows.Forms.Label();
            this.tbstaffname = new System.Windows.Forms.TextBox();
            this.tbstaffposition = new System.Windows.Forms.TextBox();
            this.tbstaffphone = new System.Windows.Forms.TextBox();
            this.tbstaffemail = new System.Windows.Forms.TextBox();
            this.btnstaffupdate = new System.Windows.Forms.Button();
            this.btnstaffdelete = new System.Windows.Forms.Button();
            this.btnstaffadd = new System.Windows.Forms.Button();
            this.dgvstaff = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstaff
            // 
            this.lblstaff.AutoSize = true;
            this.lblstaff.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.lblstaff.Location = new System.Drawing.Point(251, 23);
            this.lblstaff.Name = "lblstaff";
            this.lblstaff.Size = new System.Drawing.Size(309, 38);
            this.lblstaff.TabIndex = 2;
            this.lblstaff.Text = "STAFF MANAGEMENT";
            // 
            // lblstaffname
            // 
            this.lblstaffname.AutoSize = true;
            this.lblstaffname.Location = new System.Drawing.Point(52, 102);
            this.lblstaffname.Name = "lblstaffname";
            this.lblstaffname.Size = new System.Drawing.Size(53, 16);
            this.lblstaffname.TabIndex = 3;
            this.lblstaffname.Text = "Name : ";
            // 
            // lblstaffemail
            // 
            this.lblstaffemail.AutoSize = true;
            this.lblstaffemail.Location = new System.Drawing.Point(52, 187);
            this.lblstaffemail.Name = "lblstaffemail";
            this.lblstaffemail.Size = new System.Drawing.Size(47, 16);
            this.lblstaffemail.TabIndex = 4;
            this.lblstaffemail.Text = "Email :";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Location = new System.Drawing.Point(52, 130);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(61, 16);
            this.lblposition.TabIndex = 5;
            this.lblposition.Text = "Position :";
            // 
            // lblstaffphone
            // 
            this.lblstaffphone.AutoSize = true;
            this.lblstaffphone.Location = new System.Drawing.Point(52, 161);
            this.lblstaffphone.Name = "lblstaffphone";
            this.lblstaffphone.Size = new System.Drawing.Size(76, 16);
            this.lblstaffphone.TabIndex = 6;
            this.lblstaffphone.Text = "Phone No : ";
            // 
            // tbstaffname
            // 
            this.tbstaffname.Location = new System.Drawing.Point(146, 99);
            this.tbstaffname.Name = "tbstaffname";
            this.tbstaffname.Size = new System.Drawing.Size(189, 22);
            this.tbstaffname.TabIndex = 7;
            // 
            // tbstaffposition
            // 
            this.tbstaffposition.Location = new System.Drawing.Point(146, 133);
            this.tbstaffposition.Name = "tbstaffposition";
            this.tbstaffposition.Size = new System.Drawing.Size(189, 22);
            this.tbstaffposition.TabIndex = 8;
            // 
            // tbstaffphone
            // 
            this.tbstaffphone.Location = new System.Drawing.Point(146, 162);
            this.tbstaffphone.Name = "tbstaffphone";
            this.tbstaffphone.Size = new System.Drawing.Size(189, 22);
            this.tbstaffphone.TabIndex = 9;
            // 
            // tbstaffemail
            // 
            this.tbstaffemail.Location = new System.Drawing.Point(146, 190);
            this.tbstaffemail.Name = "tbstaffemail";
            this.tbstaffemail.Size = new System.Drawing.Size(189, 22);
            this.tbstaffemail.TabIndex = 10;
            // 
            // btnstaffupdate
            // 
            this.btnstaffupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnstaffupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaffupdate.ForeColor = System.Drawing.Color.White;
            this.btnstaffupdate.Location = new System.Drawing.Point(354, 264);
            this.btnstaffupdate.Name = "btnstaffupdate";
            this.btnstaffupdate.Size = new System.Drawing.Size(85, 34);
            this.btnstaffupdate.TabIndex = 13;
            this.btnstaffupdate.Text = "Update";
            this.btnstaffupdate.UseVisualStyleBackColor = false;
            this.btnstaffupdate.Click += new System.EventHandler(this.btnstaffupdate_Click);
            // 
            // btnstaffdelete
            // 
            this.btnstaffdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnstaffdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaffdelete.ForeColor = System.Drawing.Color.White;
            this.btnstaffdelete.Location = new System.Drawing.Point(597, 264);
            this.btnstaffdelete.Name = "btnstaffdelete";
            this.btnstaffdelete.Size = new System.Drawing.Size(85, 34);
            this.btnstaffdelete.TabIndex = 14;
            this.btnstaffdelete.Text = "Delete";
            this.btnstaffdelete.UseVisualStyleBackColor = false;
            this.btnstaffdelete.Click += new System.EventHandler(this.btnstaffdelete_Click);
            // 
            // btnstaffadd
            // 
            this.btnstaffadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnstaffadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstaffadd.ForeColor = System.Drawing.Color.White;
            this.btnstaffadd.Location = new System.Drawing.Point(93, 264);
            this.btnstaffadd.Name = "btnstaffadd";
            this.btnstaffadd.Size = new System.Drawing.Size(85, 34);
            this.btnstaffadd.TabIndex = 15;
            this.btnstaffadd.Text = "Add";
            this.btnstaffadd.UseVisualStyleBackColor = false;
            this.btnstaffadd.Click += new System.EventHandler(this.btnstaffadd_Click);
            // 
            // dgvstaff
            // 
            this.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstaff.Location = new System.Drawing.Point(36, 328);
            this.dgvstaff.Name = "dgvstaff";
            this.dgvstaff.RowHeadersWidth = 51;
            this.dgvstaff.RowTemplate.Height = 24;
            this.dgvstaff.Size = new System.Drawing.Size(731, 228);
            this.dgvstaff.TabIndex = 16;
            this.dgvstaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstaff_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(656, 582);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(132, 46);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvstaff);
            this.Controls.Add(this.btnstaffadd);
            this.Controls.Add(this.btnstaffdelete);
            this.Controls.Add(this.btnstaffupdate);
            this.Controls.Add(this.tbstaffemail);
            this.Controls.Add(this.tbstaffphone);
            this.Controls.Add(this.tbstaffposition);
            this.Controls.Add(this.tbstaffname);
            this.Controls.Add(this.lblstaffphone);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lblstaffemail);
            this.Controls.Add(this.lblstaffname);
            this.Controls.Add(this.lblstaff);
            this.Name = "StaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstaff;
        private System.Windows.Forms.Label lblstaffname;
        private System.Windows.Forms.Label lblstaffemail;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label lblstaffphone;
        private System.Windows.Forms.TextBox tbstaffname;
        private System.Windows.Forms.TextBox tbstaffposition;
        private System.Windows.Forms.TextBox tbstaffphone;
        private System.Windows.Forms.TextBox tbstaffemail;
        private System.Windows.Forms.Button btnstaffupdate;
        private System.Windows.Forms.Button btnstaffdelete;
        private System.Windows.Forms.Button btnstaffadd;
        private System.Windows.Forms.DataGridView dgvstaff;
        private System.Windows.Forms.Button btnback;
    }
}