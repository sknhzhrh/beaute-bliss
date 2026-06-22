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
    public partial class Register : Form
    {
        SqlConnection connection = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = @"INSERT INTO Customer
                        (Names, PhoneNo, Email, Addresses, Password)
                        VALUES
                        (@Names, @PhoneNo, @Email, @Addresses, @Password)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Names", txtName.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", txtPhoneNo.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Addresses", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Registered Successfully!");

                txtName.Clear();
                txtPhoneNo.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
