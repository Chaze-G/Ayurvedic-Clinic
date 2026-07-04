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
    //Login Part
    public static User ValidateLogin(string username, string password)
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            string query = "SELECT Username, Password, Role FROM Users WHERE Username=@Username AND Password=@Password";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    User u = new User();
                    u.Username = reader["Username"].ToString();
                    u.Password = reader["Password"].ToString();
                    u.Role = reader["Role"].ToString();

                    return u;
                }
            }
        }

        return null;
    }
}