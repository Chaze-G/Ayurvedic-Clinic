using System;
using System.Data.SqlClient;
using Ayurvedic_Clinic.Database;

namespace Ayurvedic_Clinic.Backend.Services
{
    public class PharmacyServices
    {
        public void SaveMedicalRecord(int patientID,
                                      int doctorID,
                                      string description,
                                      DateTime visitDate)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO MedicalPharmacy
                                (PatientID, DoctorID, Description, VisitDate)
                                VALUES
                                (@PatientID, @DoctorID, @Description, @VisitDate)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PatientID", patientID);
                cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@VisitDate", visitDate);
                cmd.ExecuteNonQuery();
            }
        }
    }
}