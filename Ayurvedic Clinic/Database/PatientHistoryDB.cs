
using System;
using System.Data.SqlClient;


public class PatientHistoryDB
{
    private string connectionString = "Server=.;Database=SuwasewanaDB;Integrated Security=True;"; // Move to DBConnection.cs later

    public void SavePrescription(string nic, string amcNumber, string prescriptionText)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO PatientHistory (NIC, VisitDate, AMCNumber, Prescription) 
                           VALUES (@NIC, @VisitDate, @AMCNumber, @Prescription)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NIC", nic);
            cmd.Parameters.AddWithValue("@VisitDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@AMCNumber", amcNumber);
            cmd.Parameters.AddWithValue("@Prescription", prescriptionText);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    
}