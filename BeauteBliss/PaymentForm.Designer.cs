namespace BeauteBliss
{
    partial class PaymentForm
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
            this.grpOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblGrandTotalRM = new System.Windows.Forms.Label();
            this.lblTaxRM = new System.Windows.Forms.Label();
            this.lblProductRM = new System.Windows.Forms.Label();
            this.lblServiceRM = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.lblServiceTotal = new System.Windows.Forms.Label();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.cmbEWallet = new System.Windows.Forms.ComboBox();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.rbEwallet = new System.Windows.Forms.RadioButton();
            this.rbOnlineBanking = new System.Windows.Forms.RadioButton();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmPayment1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.grpOrderSummary.SuspendLayout();
            this.grpPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderSummary
            // 
            this.grpOrderSummary.Controls.Add(this.lblGrandTotalRM);
            this.grpOrderSummary.Controls.Add(this.lblTaxRM);
            this.grpOrderSummary.Controls.Add(this.lblProductRM);
            this.grpOrderSummary.Controls.Add(this.lblServiceRM);
            this.grpOrderSummary.Controls.Add(this.lblGrandTotal);
            this.grpOrderSummary.Controls.Add(this.lblTax);
            this.grpOrderSummary.Controls.Add(this.lblProductTotal);
            this.grpOrderSummary.Controls.Add(this.lblServiceTotal);
            this.grpOrderSummary.Location = new System.Drawing.Point(46, 61);
            this.grpOrderSummary.Name = "grpOrderSummary";
            this.grpOrderSummary.Size = new System.Drawing.Size(422, 296);
            this.grpOrderSummary.TabIndex = 0;
            this.grpOrderSummary.TabStop = false;
            this.grpOrderSummary.Text = "Order Summary";
            // 
            // lblGrandTotalRM
            // 
            this.lblGrandTotalRM.AutoSize = true;
            this.lblGrandTotalRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalRM.Location = new System.Drawing.Point(201, 216);
            this.lblGrandTotalRM.Name = "lblGrandTotalRM";
            this.lblGrandTotalRM.Size = new System.Drawing.Size(76, 20);
            this.lblGrandTotalRM.TabIndex = 7;
            this.lblGrandTotalRM.Text = "RM 0.00";
            // 
            // lblTaxRM
            // 
            this.lblTaxRM.AutoSize = true;
            this.lblTaxRM.Location = new System.Drawing.Point(201, 162);
            this.lblTaxRM.Name = "lblTaxRM";
            this.lblTaxRM.Size = new System.Drawing.Size(69, 20);
            this.lblTaxRM.TabIndex = 6;
            this.lblTaxRM.Text = "RM 0.00";
            // 
            // lblProductRM
            // 
            this.lblProductRM.AutoSize = true;
            this.lblProductRM.Location = new System.Drawing.Point(201, 121);
            this.lblProductRM.Name = "lblProductRM";
            this.lblProductRM.Size = new System.Drawing.Size(69, 20);
            this.lblProductRM.TabIndex = 5;
            this.lblProductRM.Text = "RM 0.00";
            // 
            // lblServiceRM
            // 
            this.lblServiceRM.AutoSize = true;
            this.lblServiceRM.Location = new System.Drawing.Point(201, 76);
            this.lblServiceRM.Name = "lblServiceRM";
            this.lblServiceRM.Size = new System.Drawing.Size(69, 20);
            this.lblServiceRM.TabIndex = 4;
            this.lblServiceRM.Text = "RM 0.00";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(35, 216);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(114, 20);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "Grand Total :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(35, 153);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(79, 20);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax (6%) :";
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.Location = new System.Drawing.Point(35, 116);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(111, 20);
            this.lblProductTotal.TabIndex = 1;
            this.lblProductTotal.Text = "Product Total :";
            // 
            // lblServiceTotal
            // 
            this.lblServiceTotal.AutoSize = true;
            this.lblServiceTotal.Location = new System.Drawing.Point(35, 76);
            this.lblServiceTotal.Name = "lblServiceTotal";
            this.lblServiceTotal.Size = new System.Drawing.Size(108, 20);
            this.lblServiceTotal.TabIndex = 0;
            this.lblServiceTotal.Text = "Service Total :";
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.cmbEWallet);
            this.grpPaymentMethod.Controls.Add(this.cmbBank);
            this.grpPaymentMethod.Controls.Add(this.rbEwallet);
            this.grpPaymentMethod.Controls.Add(this.rbOnlineBanking);
            this.grpPaymentMethod.Location = new System.Drawing.Point(512, 61);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(615, 296);
            this.grpPaymentMethod.TabIndex = 1;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "Payment Method";
            // 
            // cmbEWallet
            // 
            this.cmbEWallet.Enabled = false;
            this.cmbEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEWallet.FormattingEnabled = true;
            this.cmbEWallet.Items.AddRange(new object[] {
            "Touch \'n Go eWallet",
            "GrabPay",
            "Boost",
            "ShopeePay"});
            this.cmbEWallet.Location = new System.Drawing.Point(240, 165);
            this.cmbEWallet.Name = "cmbEWallet";
            this.cmbEWallet.Size = new System.Drawing.Size(273, 33);
            this.cmbEWallet.TabIndex = 3;
            // 
            // cmbBank
            // 
            this.cmbBank.Enabled = false;
            this.cmbBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Items.AddRange(new object[] {
            "Maybank",
            "CIMB",
            "Bank Islam",
            "RHB",
            "Public Bank"});
            this.cmbBank.Location = new System.Drawing.Point(240, 92);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(273, 33);
            this.cmbBank.TabIndex = 2;
            // 
            // rbEwallet
            // 
            this.rbEwallet.AutoSize = true;
            this.rbEwallet.Location = new System.Drawing.Point(36, 174);
            this.rbEwallet.Name = "rbEwallet";
            this.rbEwallet.Size = new System.Drawing.Size(94, 24);
            this.rbEwallet.TabIndex = 1;
            this.rbEwallet.TabStop = true;
            this.rbEwallet.Text = "E-Wallet";
            this.rbEwallet.UseVisualStyleBackColor = true;
            this.rbEwallet.CheckedChanged += new System.EventHandler(this.rbEwallet_CheckedChanged);
            // 
            // rbOnlineBanking
            // 
            this.rbOnlineBanking.AutoSize = true;
            this.rbOnlineBanking.Location = new System.Drawing.Point(36, 97);
            this.rbOnlineBanking.Name = "rbOnlineBanking";
            this.rbOnlineBanking.Size = new System.Drawing.Size(141, 24);
            this.rbOnlineBanking.TabIndex = 0;
            this.rbOnlineBanking.TabStop = true;
            this.rbOnlineBanking.Text = "Online Banking";
            this.rbOnlineBanking.UseVisualStyleBackColor = true;
            this.rbOnlineBanking.CheckedChanged += new System.EventHandler(this.rbOnlineBanking_CheckedChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnConfirmPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmPayment.Location = new System.Drawing.Point(26445, 14355);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(2672, 1116);
            this.btnConfirmPayment.TabIndex = 2;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(32723, 14355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(2672, 1116);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmPayment1
            // 
            this.btnConfirmPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnConfirmPayment1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment1.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment1.Location = new System.Drawing.Point(675, 373);
            this.btnConfirmPayment1.Name = "btnConfirmPayment1";
            this.btnConfirmPayment1.Size = new System.Drawing.Size(264, 47);
            this.btnConfirmPayment1.TabIndex = 4;
            this.btnConfirmPayment1.Text = "Confirm Payment";
            this.btnConfirmPayment1.UseVisualStyleBackColor = false;
            this.btnConfirmPayment1.Click += new System.EventHandler(this.btnConfirmPayment1_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(85)))), ((int)(((byte)(116)))));
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.ForeColor = System.Drawing.Color.White;
            this.btnCancel1.Location = new System.Drawing.Point(959, 373);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(168, 47);
            this.btnCancel1.TabIndex = 5;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = false;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1182, 495);
            this.Controls.Add(this.btnCancel1);
            this.Controls.Add(this.btnConfirmPayment1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.grpPaymentMethod);
            this.Controls.Add(this.grpOrderSummary);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.grpOrderSummary.ResumeLayout(false);
            this.grpOrderSummary.PerformLayout();
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderSummary;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.Label lblServiceTotal;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.ComboBox cmbEWallet;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.RadioButton rbEwallet;
        private System.Windows.Forms.RadioButton rbOnlineBanking;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGrandTotalRM;
        private System.Windows.Forms.Label lblTaxRM;
        private System.Windows.Forms.Label lblProductRM;
        private System.Windows.Forms.Label lblServiceRM;
        private System.Windows.Forms.Button btnConfirmPayment1;
        private System.Windows.Forms.Button btnCancel1;
    }
}