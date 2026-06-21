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

        }
    }
}
