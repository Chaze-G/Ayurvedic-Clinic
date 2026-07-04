using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Database
{
    using Ayurvedic_Clinic.Backend.Models;
    using Ayurvedic_Clinic.Database;
    using System.Data.SqlClient;

    public class PharmacistDB
    {
        public static void SavePharmacist(Pharmacist p)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Pharmacist
            (PharmacistName, LicenseNo, ContactNumber, Gender)
            VALUES
            (@PharmacistName, @LicenseNo, @ContactNo, @Gender)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PharmacistName", p.Name);
                    cmd.Parameters.AddWithValue("@LicenseNo", p.LicenseNumber);
                    cmd.Parameters.AddWithValue("@ContactNo", p.ContactNumber);
                    cmd.Parameters.AddWithValue("@Gender", p.Gender);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
