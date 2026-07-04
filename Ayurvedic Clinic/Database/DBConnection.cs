using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Database
{
    public static class DBConnection
    {
        // Your personal connection string
        private static string connectionString =
            "Server=(localdb)\\MSSQLLocalDB\\SQLEXPRESS;Database=SuwasewanaDB;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}