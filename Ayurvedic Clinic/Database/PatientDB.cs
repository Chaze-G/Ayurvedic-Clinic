using Ayurvedic_Clinic.Backend.Models;
using Ayurvedic_Clinic.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Database
{



    public class PatientDB
    {
        public static void SavePatient(Patient p)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Patient 
            (NIC, PatientName, ContactNumber, Address, Gender, Age, Allergies, GuardianNIC)
            VALUES
            (@NIC, @PatientName, @ContactNumber, @Address, @Gender, @Age, @Allergies, NULL)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NIC", p.NIC);
                    cmd.Parameters.AddWithValue("@PatientName", p.Name);
                    cmd.Parameters.AddWithValue("@ContactNumber", p.ContactNumber);
                    cmd.Parameters.AddWithValue("@Address", p.Address);
                    cmd.Parameters.AddWithValue("@Gender", p.Gender);
                    cmd.Parameters.AddWithValue("@Age", p.Age);
                    cmd.Parameters.AddWithValue("@Allergies", p.Allergies);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}