namespace BeauteBliss
{
    partial class ServicesForm
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
            this.lblSelectCat = new System.Windows.Forms.Label();
            this.btnFacial = new System.Windows.Forms.Button();
            this.btnHairSpa = new System.Windows.Forms.Button();
            this.btnMassage = new System.Windows.Forms.Button();
            this.btnManicure = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSelectServ = new System.Windows.Forms.Label();
            this.lblServiceImg = new System.Windows.Forms.Label();
            this.numPax = new System.Windows.Forms.NumericUpDown();
            this.lblNoPax = new System.Windows.Forms.Label();
            this.noPax = new System.Windows.Forms.NumericUpDown();
            this.lblRequest = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnNextProduct = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_prevImg = new System.Windows.Forms.Button();
            this.btn_nextImg = new System.Windows.Forms.Button();
            this.pbServiceImage = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCat
            // 
            this.lblSelectCat.AutoSize = true;
            this.lblSelectCat.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCat.Location = new System.Drawing.Point(30, 36);
            this.lblSelectCat.Name = "lblSelectCat";
            this.lblSelectCat.Size = new System.Drawing.Size(213, 25);
            this.lblSelectCat.TabIndex = 0;
            this.lblSelectCat.Text = "Select Service Category";
            // 
            // btnFacial
            // 
            this.btnFacial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnFacial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacial.ForeColor = System.Drawing.Color.White;
            this.btnFacial.Location = new System.Drawing.Point(35, 137);
            this.btnFacial.Name = "btnFacial";
            this.btnFacial.Size = new System.Drawing.Size(145, 54);
            this.btnFacial.TabIndex = 1;
            this.btnFacial.Text = "Facial";
            this.btnFacial.UseVisualStyleBackColor = false;
            this.btnFacial.Click += new System.EventHandler(this.btnFacial_Click);
            // 
            // btnHairSpa
            // 
            this.btnHairSpa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnHairSpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHairSpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHairSpa.ForeColor = System.Drawing.Color.White;
            this.btnHairSpa.Location = new System.Drawing.Point(35, 197);
            this.btnHairSpa.Name = "btnHairSpa";
            this.btnHairSpa.Size = new System.Drawing.Size(146, 48);
            this.btnHairSpa.TabIndex = 2;
            this.btnHairSpa.Text = "Hair Spa";
            this.btnHairSpa.UseVisualStyleBackColor = false;
            this.btnHairSpa.Click += new System.EventHandler(this.btnHairSpa_Click);
            // 
            // btnMassage
            // 
            this.btnMassage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnMassage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMassage.ForeColor = System.Drawing.Color.White;
            this.btnMassage.Location = new System.Drawing.Point(36, 251);
            this.btnMassage.Name = "btnMassage";
            this.btnMassage.Size = new System.Drawing.Size(144, 52);
            this.btnMassage.TabIndex = 3;
            this.btnMassage.Text = "Massage";
            this.btnMassage.UseVisualStyleBackColor = false;
            this.btnMassage.Click += new System.EventHandler(this.btnMassage_Click);
            // 
            // btnManicure
            // 
            this.btnManicure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnManicure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManicure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManicure.ForeColor = System.Drawing.Color.White;
            this.btnManicure.Location = new System.Drawing.Point(35, 309);
            this.btnManicure.Name = "btnManicure";
            this.btnManicure.Size = new System.Drawing.Size(145, 53);
            this.btnManicure.TabIndex = 4;
            this.btnManicure.Text = "Manicure";
            this.btnManicure.UseVisualStyleBackColor = false;
            this.btnManicure.Click += new System.EventHandler(this.btnManicure_Click);
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect});
            this.dgvService.Location = new System.Drawing.Point(279, 77);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 62;
            this.dgvService.RowTemplate.Height = 28;
            this.dgvService.Size = new System.Drawing.Size(723, 271);
            this.dgvService.TabIndex = 5;
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.MinimumWidth = 8;
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Width = 150;
            // 
            // lblSelectServ
            // 
            this.lblSelectServ.AutoSize = true;
            this.lblSelectServ.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectServ.Location = new System.Drawing.Point(274, 36);
            this.lblSelectServ.Name = "lblSelectServ";
            this.lblSelectServ.Size = new System.Drawing.Size(135, 25);
            this.lblSelectServ.TabIndex = 6;
            this.lblSelectServ.Text = "Select Service ";
            // 
            // lblServiceImg
            // 
            this.lblServiceImg.AutoSize = true;
            this.lblServiceImg.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceImg.Location = new System.Drawing.Point(1039, 36);
            this.lblServiceImg.Name = "lblServiceImg";
            this.lblServiceImg.Size = new System.Drawing.Size(132, 25);
            this.lblServiceImg.TabIndex = 7;
            this.lblServiceImg.Text = "Service Image";
            // 
            // numPax
            // 
            this.numPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPax.Location = new System.Drawing.Point(1368, 17537);
            this.numPax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPax.Name = "numPax";
            this.numPax.Size = new System.Drawing.Size(6245, 30);
            this.numPax.TabIndex = 8;
            this.numPax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNoPax
            // 
            this.lblNoPax.AutoSize = true;
            this.lblNoPax.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPax.Location = new System.Drawing.Point(47, 451);
            this.lblNoPax.Name = "lblNoPax";
            this.lblNoPax.Size = new System.Drawing.Size(100, 25);
            this.lblNoPax.TabIndex = 9;
            this.lblNoPax.Text = "No. of Pax";
            // 
            // noPax
            // 
            this.noPax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPax.Location = new System.Drawing.Point(52, 488);
            this.noPax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.noPax.Name = "noPax";
            this.noPax.Size = new System.Drawing.Size(146, 30);
            this.noPax.TabIndex = 10;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(291, 451);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(270, 25);
            this.lblRequest.TabIndex = 11;
            this.lblRequest.Text = "Request / Comment (optional)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 486);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 36);
            this.textBox1.TabIndex = 12;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(1059, 470);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(180, 52);
            this.btnAddBook.TabIndex = 13;
            this.btnAddBook.Text = "ADD BOOKING";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnNextProduct
            // 
            this.btnNextProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnNextProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextProduct.ForeColor = System.Drawing.Color.White;
            this.btnNextProduct.Location = new System.Drawing.Point(1258, 471);
            this.btnNextProduct.Name = "btnNextProduct";
            this.btnNextProduct.Size = new System.Drawing.Size(208, 51);
            this.btnNextProduct.TabIndex = 14;
            this.btnNextProduct.Text = "NEXT (PRODUCT)";
            this.btnNextProduct.UseVisualStyleBackColor = false;
            this.btnNextProduct.Click += new System.EventHandler(this.btnNextProduct_Click);
            // 
            // btn_All
            // 
            this.btn_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btn_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.ForeColor = System.Drawing.Color.White;
            this.btn_All.Location = new System.Drawing.Point(36, 77);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(145, 54);
            this.btn_All.TabIndex = 16;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = false;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_prevImg
            // 
            this.btn_prevImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btn_prevImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prevImg.ForeColor = System.Drawing.Color.White;
            this.btn_prevImg.Location = new System.Drawing.Point(975, 405);
            this.btn_prevImg.Name = "btn_prevImg";
            this.btn_prevImg.Size = new System.Drawing.Size(63, 34);
            this.btn_prevImg.TabIndex = 17;
            this.btn_prevImg.Text = "<<";
            this.btn_prevImg.UseVisualStyleBackColor = false;
            this.btn_prevImg.Click += new System.EventHandler(this.btn_prevImg_Click);
            // 
            // btn_nextImg
            // 
            this.btn_nextImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btn_nextImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextImg.ForeColor = System.Drawing.Color.White;
            this.btn_nextImg.Location = new System.Drawing.Point(1403, 405);
            this.btn_nextImg.Name = "btn_nextImg";
            this.btn_nextImg.Size = new System.Drawing.Size(63, 34);
            this.btn_nextImg.TabIndex = 18;
            this.btn_nextImg.Text = ">>";
            this.btn_nextImg.UseVisualStyleBackColor = false;
            this.btn_nextImg.Click += new System.EventHandler(this.btn_nextImg_Click);
            // 
            // pbServiceImage
            // 
            this.pbServiceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbServiceImage.Location = new System.Drawing.Point(1044, 77);
            this.pbServiceImage.Name = "pbServiceImage";
            this.pbServiceImage.Size = new System.Drawing.Size(353, 313);
            this.pbServiceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbServiceImage.TabIndex = 15;
            this.pbServiceImage.TabStop = false;
            // 
            // lblImageName
            // 
            this.lblImageName.Location = new System.Drawing.Point(1044, 408);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(353, 35);
            this.lblImageName.TabIndex = 19;
            this.lblImageName.Text = "label1";
            this.lblImageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1525, 552);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.btn_nextImg);
            this.Controls.Add(this.btn_prevImg);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.pbServiceImage);
            this.Controls.Add(this.btnNextProduct);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.noPax);
            this.Controls.Add(this.lblNoPax);
            this.Controls.Add(this.numPax);
            this.Controls.Add(this.lblServiceImg);
            this.Controls.Add(this.lblSelectServ);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnManicure);
            this.Controls.Add(this.btnMassage);
            this.Controls.Add(this.btnHairSpa);
            this.Controls.Add(this.btnFacial);
            this.Controls.Add(this.lblSelectCat);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Name = "ServicesForm";
            this.Text = "Service Form";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noPax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServiceImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCat;
        private System.Windows.Forms.Button btnFacial;
        private System.Windows.Forms.Button btnHairSpa;
        private System.Windows.Forms.Button btnMassage;
        private System.Windows.Forms.Button btnManicure;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Label lblSelectServ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.Label lblServiceImg;
        private System.Windows.Forms.NumericUpDown numPax;
        private System.Windows.Forms.Label lblNoPax;
        private System.Windows.Forms.NumericUpDown noPax;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnNextProduct;
        private System.Windows.Forms.PictureBox pbServiceImage;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_prevImg;
        private System.Windows.Forms.Button btn_nextImg;
        private System.Windows.Forms.Label lblImageName;
    }
}