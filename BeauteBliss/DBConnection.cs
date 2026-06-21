using System.Data.SqlClient;


namespace BeauteBliss
{
    class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;
          AttachDbFilename=|DataDirectory|\BeauteblissDB.mdf;
          Integrated Security=True");
        }
    }
}