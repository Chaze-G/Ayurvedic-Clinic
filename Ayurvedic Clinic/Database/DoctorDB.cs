using Ayurvedic_Clinic.Backend.Models;
using Ayurvedic_Clinic.Database;
using System.Data.SqlClient;

public class DoctorDB
{
    public static void SaveDoctor(Doctor d)
    {
        using (SqlConnection con = DBConnection.GetConnection())
        {
            con.Open();

            string query = @"INSERT INTO Doctor 
            (DoctorName, AMCNo, SpecializedFor, ContactNumber, Gender)
            VALUES
            (@DoctorName, @AMCNo, @SpecializedFor, @ContactNumber, @Gender)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@DoctorName", d.Name); // from Person
                cmd.Parameters.AddWithValue("@AMCNo", d.AMCNo);
                cmd.Parameters.AddWithValue("@SpecializedFor", d.SpecializedFor);
                cmd.Parameters.AddWithValue("@ContactNumber", d.ContactNumber); // from Person
                cmd.Parameters.AddWithValue("@Gender", d.Gender);

                cmd.ExecuteNonQuery();
            }
        }
    }
}