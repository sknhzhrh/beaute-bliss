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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            dgvReceipt.Rows.Clear();

            decimal grandTotal = 0;

            foreach (CartItem item in CartManager.Cart)
            {
                decimal total =
                    item.Price *
                    item.Quantity;

                dgvReceipt.Rows.Add(
                    item.ItemName,
                    item.Type,
                    item.Quantity,
                    item.Price,
                    total
                );

                grandTotal += total;
            }

            decimal tax =
                grandTotal * 0.06m;

            grandTotal += tax;

            lblGrandTotal.Text =
                "RM " +
                grandTotal.ToString("0.00");

            lblDate.Text =
                DateTime.Now.ToString(
                    "dd/MM/yyyy hh:mm tt");

            lblOrderNo.Text =
                "ORD" +
                DateTime.Now.ToString(
                    "yyyyMMddHHmmss");
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            CartManager.Cart.Clear();

            ServicesForm service =
                new ServicesForm();

            service.Show();

            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt printed successfully!");
        }
    }
}
