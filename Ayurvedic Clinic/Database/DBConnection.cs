using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Database
{
    public static class DBConnection
    {
       
        public static SqlConnection GetConnection()
        {
            string connString = @"Server=.\SQLEXPRESS;Database=SuwasewanaDB;Integrated Security=True;";
            return new SqlConnection(connString);
        }
    }
}