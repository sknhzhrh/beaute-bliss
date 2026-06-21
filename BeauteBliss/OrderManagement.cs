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
    public partial class OrderManagement : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");

        public OrderManagement()
        {
            InitializeComponent();
        }

        private void LoadBookingData()
        {
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Booking", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvbooking.DataSource = dt;

            connection.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadBookingData();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            tbsearch.Clear();
            LoadBookingData();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvbooking.CurrentRow == null)
            {
                MessageBox.Show("Please select a booking first.");
                return;
            }

            if (cmbstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvbooking.CurrentRow.Cells["BookingID"].Value);

            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Booking SET BookStatus = @status WHERE BookingID = @bookingID",
                connection);

            cmd.Parameters.AddWithValue("@status", cmbstatus.Text);
            cmd.Parameters.AddWithValue("@bookingID", bookingID);

            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Booking status updated successfully.");
            LoadBookingData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT * FROM Booking
                  WHERE CAST(BookingID AS NVARCHAR) LIKE @search
                  OR CAST(CustomerID AS NVARCHAR) LIKE @search
                  OR BookStatus LIKE @search",
                connection);

            da.SelectCommand.Parameters.AddWithValue("@search", "%" + tbsearch.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvbooking.DataSource = dt;

            connection.Close();
        }
    }
}