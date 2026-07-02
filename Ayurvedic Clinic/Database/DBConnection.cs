using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Database
{
    public static class DBConnection
    {
        private static readonly string connectionString =
            "Server=DESKTOP-0DQD6HP\\SQLEXPRESS;Database=SuwasewanaDB;Integrated Security=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}