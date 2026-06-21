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

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataTable dt = (DataTable)dataGridView1.DataSource;
                adapter.Update(dt);

                connection.Close();

                MessageBox.Show("Customer Updated Successfully");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter Customer ID");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Customer WHERE CustomerID=@CustomerID", connection);

                cmd.Parameters.AddWithValue("@CustomerID", txtSearch.Text);

                cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Customer Deleted Successfully");

                txtSearch.Clear();
                LoadCustomerData();
            }
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
