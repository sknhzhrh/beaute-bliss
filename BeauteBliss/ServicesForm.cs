using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeauteBliss
{
    public partial class ServicesForm : Form
    {
        private string[] serviceImages =
    {
        @"Images\Brightening Facial.jpg",
        @"Images\acne treatment.jpg",
        @"Images\hair treatment.jpg",
        @"Images\foot massage.jpg",
        @"Images\french tip manicure.jpg"
    };

        private string[] serviceNames =
    {
        "Brightening Facial",
        "Acne Treatment Facial",
        "Hair Spa Treatment",
        "Foot Massage",
        "French Tip Manicure"
    };

        private int currentImage = 0;

        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            LoadServices();
            LoadImage();
        }

        private void LoadServices(string category = "")
        {
            SqlConnection con = DBConnection.GetConnection();

            string query =
        "SELECT ServiceName, Price, Duration " +
        "FROM ServiceList";

            if (category != "")
            {
                query += " WHERE Category = @Category";
            }

            SqlCommand cmd = new SqlCommand(query, con);

            if (category != "")
            {
                cmd.Parameters.AddWithValue("@Category", category);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvService.DataSource = dt;
        }

        private void LoadImage()
        {
            string fullPath =
            System.IO.Path.Combine(
            Application.StartupPath,
            serviceImages[currentImage]);

            pbServiceImage.Image =
                Image.FromFile(fullPath);

            lblImageName.Text =
            serviceNames[currentImage];
        }

        private void btnFacial_Click(object sender, EventArgs e)
        {
            LoadServices("Facial");
        }

        private void btnHairSpa_Click(object sender, EventArgs e)
        {
            LoadServices("Hair Spa");
        }

        private void btnMassage_Click(object sender, EventArgs e)
        {
            LoadServices("Massage");
        }

        private void btnManicure_Click(object sender, EventArgs e)
        {
            LoadServices("Manicure");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bool serviceSelected = false;

            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.Cells["ColSelect"].Value != null &&
                    Convert.ToBoolean(row.Cells["ColSelect"].Value))
                {
                    serviceSelected = true;
                    break;
                }
            }

            if (serviceSelected && noPax.Value <= 0)
            {
                MessageBox.Show(
                    "Please enter number of pax greater than 0.");

                noPax.Focus();

                return;
            }

            CartManager.Cart.RemoveAll(
                item => item.Type == "Service");

            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.Cells["ColSelect"].Value != null &&
                    Convert.ToBoolean(row.Cells["ColSelect"].Value))
                {
                    CartItem item = new CartItem();

                    item.ItemName =
                        row.Cells["ServiceName"]
                        .Value.ToString();

                    item.Price =
                        Convert.ToDecimal(
                            row.Cells["Price"]
                            .Value);

                    item.Quantity =
                        (int)noPax.Value;

                    item.Type = "Service";

                    CartManager.Cart.Add(item);
                }
            }

            MessageBox.Show(
                "Service(s) added successfully!");
        }

        private void btnNextProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(this);
            productForm.Show();

            this.Hide();
        }

        private void btn_nextImg_Click(object sender, EventArgs e)
        {
            currentImage++;

            if (currentImage >=
                serviceImages.Length)
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
                    serviceImages.Length - 1;
            }

            LoadImage();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadServices();
        }
    }
}
