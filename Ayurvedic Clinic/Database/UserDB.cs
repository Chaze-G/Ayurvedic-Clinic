using Ayurvedic_Clinic.Backend.Models;
using Ayurvedic_Clinic.Database;
using System.Data.SqlClient;

public class UserDB
{
    public static void InsertUser(User u)
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            string query = @"INSERT INTO Users
            (Username, Password, Role)
            VALUES
            (@Username, @Password, @Role)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@Role", u.Role);

                cmd.ExecuteNonQuery();
            }
        }
    }
}