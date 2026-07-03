using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Database
{
    public static class DBConnection
    {
        private static readonly string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=SuwasewanaDB;Integrated Security=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}