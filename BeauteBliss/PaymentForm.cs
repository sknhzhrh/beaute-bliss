using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeauteBliss
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void rbOnlineBanking_CheckedChanged(object sender, EventArgs e)
        {
            cmbBank.Enabled = rbOnlineBanking.Checked;
            cmbEWallet.Enabled = false;
            cmbEWallet.SelectedIndex = -1;
        }

        private void rbEwallet_CheckedChanged(object sender, EventArgs e)
        {
            cmbEWallet.Enabled = rbEwallet.Checked;
            cmbBank.Enabled = false;
            cmbBank.SelectedIndex = -1;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            decimal serviceTotal = 0;

            decimal productTotal = 0;

            foreach (CartItem item in CartManager.Cart)
            {
                decimal total =
                    item.Price * item.Quantity;

                if (item.Type == "Service")
                {
                    serviceTotal += total;
                }

                else if (item.Type == "Product")
                {
                    productTotal += total;
                }
            }

            decimal subtotal =
                serviceTotal + productTotal;

            decimal tax =
                subtotal * 0.06m;

            decimal grandTotal =
                subtotal + tax;

            lblServiceRM.Text =
                "RM " + serviceTotal.ToString("0.00");

            lblProductRM.Text =
                "RM " + productTotal.ToString("0.00");

            lblTaxRM.Text =
                "RM " + tax.ToString("0.00");

            lblGrandTotalRM.Text =
                "RM " + grandTotal.ToString("0.00");
        }

        private ProductForm productForm;

        public PaymentForm(ProductForm form)
        {
            InitializeComponent();

            productForm = form;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

            if (CartManager.Cart.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one service or product.");

                return;
            }

            if (!rbOnlineBanking.Checked &&
       !rbEwallet.Checked)
            {
                MessageBox.Show(
                    "Please select a payment method.");

                return;
            }

            if (rbOnlineBanking.Checked &&
                cmbBank.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a bank.");

                return;
            }

            if (rbEwallet.Checked &&
                cmbEWallet.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an e-wallet.");

                return;
            }

            MessageBox.Show(
                "Payment Successful!");

            ReceiptForm receipt =
                new ReceiptForm();

            receipt.Show();

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            productForm.Show();
            this.Close();
        }

        private void btnConfirmPayment1_Click(object sender, EventArgs e)
        {
            if (CartManager.Cart.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one service or product.");

                return;
            }

            if (!rbOnlineBanking.Checked &&
       !rbEwallet.Checked)
            {
                MessageBox.Show(
                    "Please select a payment method.");

                return;
            }

            if (rbOnlineBanking.Checked &&
                cmbBank.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a bank.");

                return;
            }

            if (rbEwallet.Checked &&
                cmbEWallet.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an e-wallet.");

                return;
            }

            MessageBox.Show(
                "Payment Successful!");

            ReceiptForm receipt =
                new ReceiptForm();

            receipt.Show();

            this.Hide();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            productForm.Show();
            this.Close();
        }
    }
}
