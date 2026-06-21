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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbusername.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username");
                tbusername.Focus();
                return;
            }

            if (tbpassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password");
                tbpassword.Focus();
                return;
            }

            if (tbusername.Text == "admin" && tbpassword.Text == "1234")
            {
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void cbpassword_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = !cbpassword.Checked;
        }
    }
}
