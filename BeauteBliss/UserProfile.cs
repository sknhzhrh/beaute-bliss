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
using System.Xml.Linq;

namespace BeauteBliss
{
    public partial class UserProfile : Form
    {
        SqlConnection connection = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");

        int customerID;
        public UserProfile(int id)
        {
            InitializeComponent();
            customerID = id;
        }

        private void LoadProfile()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(
    "SELECT * FROM Customer WHERE CustomerID=@CustomerID", connection);

            cmd.Parameters.AddWithValue("@CustomerID", customerID);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtName.Text = reader["Names"].ToString();
                txtPhoneNo.Text = reader["PhoneNo"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtAddress.Text = reader["Addresses"].ToString();
            }

            reader.Close();
            connection.Close();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement();
            customer.Show();
        }
    }
}
