using System;
using System.Data;
using System.Data.SqlClient;

public class PatientHistoryDB
{
    private string connectionString = @"Server=.\SQLEXPRESS;Database=SuwasewanaDB;Integrated Security=True;";

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


    public DataTable GetPatientHistory(string nic)
    {
        DataTable dt = new DataTable();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"SELECT HistoryID, 
                                    VisitDate, 
                                    AMCNumber, 
                                    Prescription 
                             FROM PatientHistory 
                             WHERE NIC = @NIC 
                             ORDER BY VisitDate DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@NIC", nic);
            da.Fill(dt);
        }

        return dt;
    }
}