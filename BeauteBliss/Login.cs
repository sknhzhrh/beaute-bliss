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
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                string query = "SELECT CustomerID FROM Customer WHERE Names=@Names AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Names", txtName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int customerID = Convert.ToInt32(result);

                    MessageBox.Show("Login Successful!");

                    UserProfile form = new UserProfile(customerID);
                    form.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
