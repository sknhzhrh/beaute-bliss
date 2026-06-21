using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeauteBliss
{
    public partial class ProductForm : Form
    {

        private string[] productImages =
    {
        @"Images\facial cleanser.jpg",
        @"Images\body lotion.jpg",
        @"Images\nail polish.jpg",
        @"Images\hair serum.jpg"
    };

        private string[] productNames =
    {
        "Facial Cleanser",
        "Body Lotion",
        "Nail Polish",
        "Hair Serum"
    };

        private int currentImage = 0;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void LoadProducts(string category = "")
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                string query =
                    "SELECT ProductName, Brand, Price " +
                    "FROM Products";

                if (category != "")
                {
                    query += " WHERE Category = @Category";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (category != "")
                    {
                        cmd.Parameters.AddWithValue("@Category", category);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvProduct.DataSource = dt;
                }

            }
            
        }

        private void LoadImage()
        {
            string fullPath =
                System.IO.Path.Combine(
                    Application.StartupPath,
                    productImages[currentImage]);

            if (System.IO.File.Exists(fullPath))
            {
                if (pbProductImage.Image != null)
                {
                    pbProductImage.Image.Dispose();
                }

                pbProductImage.Image =
                    Image.FromFile(fullPath);

                lblImageName.Text =
                productNames[currentImage];
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells["ColSelect"].Value != null &&
                    Convert.ToBoolean(row.Cells["ColSelect"].Value))
                {
                    int qty = Convert.ToInt32(
                        row.Cells["Qty"].Value);

                    if (qty > 0)
                    {
                        string productName =
                            row.Cells["ProductName"]
                            .Value.ToString();

                        CartItem existing =
                            CartManager.Cart
                            .FirstOrDefault(
                                x => x.Type == "Product"
                                && x.ItemName == productName);

                        if (existing == null)
                        {
                            CartItem item =
                                new CartItem();

                            item.ItemName = productName;

                            item.Price =
                                Convert.ToDecimal(
                                    row.Cells["Price"]
                                    .Value);

                            item.Quantity = qty;

                            item.Type = "Product";

                            CartManager.Cart.Add(item);
                        }
                        else
                        {
                            existing.Quantity = qty;
                        }
                    }
                }
            }

            LoadCart();

            MessageBox.Show(
                "Product(s) added successfully!");
        }

        private void LoadCart()
        {
            dgvCart.Rows.Clear();

            foreach (CartItem item
                in CartManager.Cart)
            {
                if (item.Type == "Product")
                {
                    decimal total =
                        item.Price *
                        item.Quantity;

                    dgvCart.Rows.Add(
                        item.ItemName,
                        item.Quantity,
                        item.Price,
                        total
                    );
                }
            }

            CalculateTotal();
        }

        private void ProductForm_Load(object sender,EventArgs e)
        {
            LoadCart();
            LoadProducts();
            LoadImage();
        }

        private void btnSkinCare_Click(object sender, EventArgs e)
        {
            LoadProducts("Skin Care");
        }

        private void btnHairCare_Click(object sender, EventArgs e)
        {
            LoadProducts("Hair Care");
        }

        private void dgvProduct_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvProduct.Columns[e.ColumnIndex].Name == "Qty")
            {
                int qty;

                if (!int.TryParse(e.FormattedValue.ToString(), out qty)
                    || qty < 0)
                {
                    MessageBox.Show(
                        "Quantity cannot be negative.");

                    e.Cancel = true;
                }
            }
        }

        private void CalculateTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["colTotal"].Value != null)
                {
                    grandTotal += Convert.ToDecimal(
                        row.Cells["colTotal"].Value);
                }
            }

            tb_price.Text = grandTotal.ToString("0.00");
        }

        private ServicesForm servicesForm;

        public ProductForm(ServicesForm form)
        {
            InitializeComponent();
            servicesForm = form;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            servicesForm.Show();
            this.Close();
        }

        private void btnNextpayment_Click(object sender, EventArgs e)
        {
            PaymentForm payment = new PaymentForm(this);
            payment.Show();
            this.Hide();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btn_nextImg_Click(object sender, EventArgs e)
        {
            currentImage++;

            if (currentImage >=
                productImages.Length)
            {
                currentImage = 0;
            }

            LoadImage();
        }

        private void btn_prevImg_Click(object sender, EventArgs e)
        {
            currentImage--;

            if (currentImage < 0)
            {
                currentImage =
                    productImages.Length - 1;
            }

            LoadImage();
        }
    }
}
