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
    public partial class StaffManagement : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");
        public StaffManagement()
        {
            InitializeComponent();
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Staffs", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvstaff.DataSource = dt;
        }
        private void ClearFields()
        {
            tbstaffname.Clear();
            tbstaffposition.Clear();
            tbstaffphone.Clear();
            tbstaffemail.Clear();
        }

        private void btnstaffadd_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Staffs (Names, Positions, PhoneNo, Email) VALUES (@name,@position,@phone,@email)",
                connection);

            cmd.Parameters.AddWithValue("@name", tbstaffname.Text);
            cmd.Parameters.AddWithValue("@position", tbstaffposition.Text);
            cmd.Parameters.AddWithValue("@phone", tbstaffphone.Text);
            cmd.Parameters.AddWithValue("@email", tbstaffemail.Text);

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Staff added successfully.");

            LoadStaffData();
            ClearFields();
        }

        private void btnstaffupdate_Click(object sender, EventArgs e)
        {
            if (dgvstaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff.");
                return;
            }

            int staffID = Convert.ToInt32(dgvstaff.CurrentRow.Cells["StaffID"].Value);

            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Staffs SET Names=@name, Positions=@position, PhoneNo=@phone, Email=@email WHERE StaffID=@id",
                connection);

            cmd.Parameters.AddWithValue("@name", tbstaffname.Text);
            cmd.Parameters.AddWithValue("@position", tbstaffposition.Text);
            cmd.Parameters.AddWithValue("@phone", tbstaffphone.Text);
            cmd.Parameters.AddWithValue("@email", tbstaffemail.Text);
            cmd.Parameters.AddWithValue("@id", staffID);

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Staff updated successfully.");

            LoadStaffData();
            ClearFields();
        }

        private void btnstaffdelete_Click(object sender, EventArgs e)
        {
            if (dgvstaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a staff.");
                return;
            }

            int staffID = Convert.ToInt32(dgvstaff.CurrentRow.Cells["StaffID"].Value);

            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Staffs WHERE StaffID=@id",
                connection);

            cmd.Parameters.AddWithValue("@id", staffID);

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Staff deleted successfully.");

            LoadStaffData();
            ClearFields();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void dgvstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvstaff.Rows[e.RowIndex];

                tbstaffname.Text = row.Cells["Names"].Value.ToString();
                tbstaffposition.Text = row.Cells["Positions"].Value.ToString();
                tbstaffphone.Text = row.Cells["PhoneNo"].Value.ToString();
                tbstaffemail.Text = row.Cells["Email"].Value.ToString();
            }
        }
    }
}
