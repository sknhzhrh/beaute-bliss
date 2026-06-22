using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BeauteBliss
{
    public partial class CustomerManagement : Form
    {
        SqlConnection connection = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");

        int selectedCustomerID = 0;
        public CustomerManagement()
        {
            InitializeComponent();
            
        }

        private void LoadCustomerData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter Customer ID");
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT * FROM Customer WHERE CustomerID=@CustomerID", connection);

            adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", txtSearch.Text);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter Customer ID.");
                return;
            }

            int customerID = Convert.ToInt32(txtSearch.Text);

            DialogResult confirm = MessageBox.Show(
                "This will delete the customer's booking records first. Continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

                connection.Open();

                SqlCommand deleteBooking = new SqlCommand(
                    "DELETE FROM Booking WHERE CustomerID=@CustomerID", connection);
                deleteBooking.Parameters.AddWithValue("@CustomerID", customerID);
                deleteBooking.ExecuteNonQuery();

                SqlCommand deleteCustomer = new SqlCommand(
                    "DELETE FROM Customer WHERE CustomerID=@CustomerID", connection);
                deleteCustomer.Parameters.AddWithValue("@CustomerID", customerID);

                int rows = deleteCustomer.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Customer deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Customer ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            LoadCustomerData();
        }

        private void refbtn_Click(object sender, EventArgs e)
        {
            selectedCustomerID = 0;
            txtSearch.Clear();
            LoadCustomerData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedCustomerID = Convert.ToInt32(row.Cells["CustomerID"].Value);
                txtSearch.Text = selectedCustomerID.ToString();
            }
        }

    }
}
