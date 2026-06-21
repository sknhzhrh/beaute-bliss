namespace BeauteBliss
{
    partial class ProductForm
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
            this.btnSkinCare = new System.Windows.Forms.Button();
            this.btnHairCare = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectProd = new System.Windows.Forms.Label();
            this.lblProdImg = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnNextpayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRM = new System.Windows.Forms.Label();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_nextImg = new System.Windows.Forms.Button();
            this.btn_prevImg = new System.Windows.Forms.Button();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblImageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCat
            // 
            this.lblSelectCat.AutoSize = true;
            this.lblSelectCat.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCat.Location = new System.Drawing.Point(24, 36);
            this.lblSelectCat.Name = "lblSelectCat";
            this.lblSelectCat.Size = new System.Drawing.Size(218, 25);
            this.lblSelectCat.TabIndex = 1;
            this.lblSelectCat.Text = "Select Product Category";
            // 
            // btnSkinCare
            // 
            this.btnSkinCare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnSkinCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkinCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkinCare.ForeColor = System.Drawing.Color.White;
            this.btnSkinCare.Location = new System.Drawing.Point(29, 136);
            this.btnSkinCare.Name = "btnSkinCare";
            this.btnSkinCare.Size = new System.Drawing.Size(145, 54);
            this.btnSkinCare.TabIndex = 2;
            this.btnSkinCare.Text = "Skin Care";
            this.btnSkinCare.UseVisualStyleBackColor = false;
            this.btnSkinCare.Click += new System.EventHandler(this.btnSkinCare_Click);
            // 
            // btnHairCare
            // 
            this.btnHairCare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnHairCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHairCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHairCare.ForeColor = System.Drawing.Color.White;
            this.btnHairCare.Location = new System.Drawing.Point(29, 196);
            this.btnHairCare.Name = "btnHairCare";
            this.btnHairCare.Size = new System.Drawing.Size(145, 54);
            this.btnHairCare.TabIndex = 3;
            this.btnHairCare.Text = "Hair Care";
            this.btnHairCare.UseVisualStyleBackColor = false;
            this.btnHairCare.Click += new System.EventHandler(this.btnHairCare_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelect,
            this.Qty});
            this.dgvProduct.Location = new System.Drawing.Point(294, 77);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(716, 200);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProduct_CellValidating);
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.MinimumWidth = 8;
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Width = 150;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            this.Qty.Width = 150;
            // 
            // lblSelectProd
            // 
            this.lblSelectProd.AutoSize = true;
            this.lblSelectProd.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProd.Location = new System.Drawing.Point(289, 36);
            this.lblSelectProd.Name = "lblSelectProd";
            this.lblSelectProd.Size = new System.Drawing.Size(140, 25);
            this.lblSelectProd.TabIndex = 5;
            this.lblSelectProd.Text = "Select Product ";
            // 
            // lblProdImg
            // 
            this.lblProdImg.AutoSize = true;
            this.lblProdImg.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdImg.Location = new System.Drawing.Point(1050, 36);
            this.lblProdImg.Name = "lblProdImg";
            this.lblProdImg.Size = new System.Drawing.Size(137, 25);
            this.lblProdImg.TabIndex = 6;
            this.lblProdImg.Text = "Product Image";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(742, 562);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "PRICE";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(872, 558);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(138, 30);
            this.tb_price.TabIndex = 11;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnAddCart.Location = new System.Drawing.Point(861, 294);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(149, 39);
            this.btnAddCart.TabIndex = 12;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colitem,
            this.colQty,
            this.colPrice,
            this.colTotal});
            this.dgvCart.Location = new System.Drawing.Point(294, 394);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(716, 150);
            this.dgvCart.TabIndex = 13;
            // 
            // colitem
            // 
            this.colitem.HeaderText = "Item";
            this.colitem.MinimumWidth = 8;
            this.colitem.Name = "colitem";
            this.colitem.Width = 150;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 8;
            this.colQty.Name = "colQty";
            this.colQty.Width = 90;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 120;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 120;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(289, 355);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(82, 25);
            this.lblCart.TabIndex = 14;
            this.lblCart.Text = "Cart List";
            // 
            // btnNextpayment
            // 
            this.btnNextpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnNextpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextpayment.ForeColor = System.Drawing.Color.White;
            this.btnNextpayment.Location = new System.Drawing.Point(1209, 597);
            this.btnNextpayment.Name = "btnNextpayment";
            this.btnNextpayment.Size = new System.Drawing.Size(208, 51);
            this.btnNextpayment.TabIndex = 15;
            this.btnNextpayment.Text = "NEXT (PAYMENT)";
            this.btnNextpayment.UseVisualStyleBackColor = false;
            this.btnNextpayment.Click += new System.EventHandler(this.btnNextpayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(29, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 51);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "BACK (SERVICE)";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            this.lblRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRM.Location = new System.Drawing.Point(822, 560);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(44, 25);
            this.lblRM.TabIndex = 17;
            this.lblRM.Text = "RM";
            this.lblRM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_All
            // 
            this.btn_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btn_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.ForeColor = System.Drawing.Color.White;
            this.btn_All.Location = new System.Drawing.Point(29, 77);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(145, 54);
            this.btn_All.TabIndex = 20;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = false;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_nextImg
            // 
            this.btn_nextImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btn_nextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextImg.ForeColor = System.Drawing.Color.White;
            this.btn_nextImg.Location = new System.Drawing.Point(1345, 437);
            this.btn_nextImg.Name = "btn_nextImg";
            this.btn_nextImg.Size = new System.Drawing.Size(63, 34);
            this.btn_nextImg.TabIndex = 23;
            this.btn_nextImg.Text = ">>";
            this.btn_nextImg.UseVisualStyleBackColor = false;
            this.btn_nextImg.Click += new System.EventHandler(this.btn_nextImg_Click);
            // 
            // btn_prevImg
            // 
            this.btn_prevImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btn_prevImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prevImg.ForeColor = System.Drawing.Color.White;
            this.btn_prevImg.Location = new System.Drawing.Point(1055, 436);
            this.btn_prevImg.Name = "btn_prevImg";
            this.btn_prevImg.Size = new System.Drawing.Size(63, 34);
            this.btn_prevImg.TabIndex = 22;
            this.btn_prevImg.Text = "<<";
            this.btn_prevImg.UseVisualStyleBackColor = false;
            this.btn_prevImg.Click += new System.EventHandler(this.btn_prevImg_Click);
            // 
            // pbProductImage
            // 
            this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProductImage.Location = new System.Drawing.Point(1055, 77);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(353, 340);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductImage.TabIndex = 21;
            this.pbProductImage.TabStop = false;
            // 
            // lblImageName
            // 
            this.lblImageName.Location = new System.Drawing.Point(1139, 435);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(184, 35);
            this.lblImageName.TabIndex = 24;
            this.lblImageName.Text = "label1";
            this.lblImageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1470, 682);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.btn_nextImg);
            this.Controls.Add(this.btn_prevImg);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.lblRM);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNextpayment);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProdImg);
            this.Controls.Add(this.lblSelectProd);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnHairCare);
            this.Controls.Add(this.btnSkinCare);
            this.Controls.Add(this.lblSelectCat);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCat;
        private System.Windows.Forms.Button btnSkinCare;
        private System.Windows.Forms.Button btnHairCare;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblSelectProd;
        private System.Windows.Forms.Label lblProdImg;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnNextpayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRM;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_nextImg;
        private System.Windows.Forms.Button btn_prevImg;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblImageName;
    }
}