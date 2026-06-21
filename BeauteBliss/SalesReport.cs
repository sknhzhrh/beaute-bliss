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
using System.Windows.Forms.DataVisualization.Charting;

namespace BeauteBliss
{
    public partial class SalesReport : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BeauteBlissDB.mdf;Integrated Security=True");
        public SalesReport()
        {
            InitializeComponent();
        }

        private void LoadTotalSales()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT ISNULL(SUM(Total),0) FROM Payment",
                connection);

            decimal totalSales = Convert.ToDecimal(cmd.ExecuteScalar());

            lbltotalsales.Text = "RM " + totalSales.ToString("0.00");

            connection.Close();
        }

        private void LoadTotalBookings()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Booking",
                connection);

            int totalBookings = Convert.ToInt32(cmd.ExecuteScalar());

            lbltotalbookings.Text = totalBookings.ToString();

            connection.Close();
        }

        private void LoadChart()
        {
            chartsales.Series.Clear();
            chartsales.Titles.Clear();

            Series series = new Series("Sales");
            series.ChartType = SeriesChartType.Column;

            chartsales.Series.Add(series);

            SqlCommand cmd = new SqlCommand(
                @"SELECT MONTH(PaymentDate) AS MonthNo,
                  SUM(Total) AS TotalSales
                  FROM Payment
                  WHERE PaymentDate BETWEEN @startDate AND @endDate
                  GROUP BY MONTH(PaymentDate)
                  ORDER BY MonthNo",
                connection);

            cmd.Parameters.AddWithValue("@startDate", dtpstart.Value.Date);
            cmd.Parameters.AddWithValue("@endDate", dtpend.Value.Date);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string monthName = new DateTime(
                    DateTime.Now.Year,
                    Convert.ToInt32(reader["MonthNo"]),
                    1).ToString("MMM");

                series.Points.AddXY(
                    monthName,
                    Convert.ToDecimal(reader["TotalSales"])
                );
            }

            reader.Close();

            chartsales.Titles.Add("Monthly Sales");

            connection.Close();
        }

        private void LoadServiceCategoryChart()
        {
            chartcategory.Series.Clear();
            chartcategory.Titles.Clear();

            Series series = new Series("Service Category");
            series.ChartType = SeriesChartType.Pie;

            chartcategory.Series.Add(series);

            SqlCommand cmd = new SqlCommand(
                @"SELECT s.Category, COUNT(*) AS TotalBookings
                  FROM Booking b
                  INNER JOIN ServiceList s ON b.ServiceID = s.ServiceID
                  WHERE b.BookingDate BETWEEN @startDate AND @endDate
                  GROUP BY s.Category",
                connection);

            cmd.Parameters.AddWithValue("@startDate", dtpstart.Value.Date);
            cmd.Parameters.AddWithValue("@endDate", dtpend.Value.Date);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                series.Points.AddXY(
                    reader["Category"].ToString(),
                    Convert.ToInt32(reader["TotalBookings"])
                );
            }

            reader.Close();
            connection.Close();

            chartcategory.Titles.Add("Service Category Distribution");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            LoadTotalSales();
            LoadTotalBookings();
            LoadChart();
            LoadServiceCategoryChart();

            MessageBox.Show("Report Generated Successfully!");
        }
    }
}
