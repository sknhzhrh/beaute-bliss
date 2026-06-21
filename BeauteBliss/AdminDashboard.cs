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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            OrderManagement order = new OrderManagement();
            order.Show();
            this.Hide();
        }

        private void buttonsales_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport();
            sales.Show();
            this.Hide();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AdminLogin login = new AdminLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            StaffManagement staff = new StaffManagement();
            staff.Show();
            this.Hide();
        }
    }
}
