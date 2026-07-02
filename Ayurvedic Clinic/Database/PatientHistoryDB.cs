using System;
using System.Data;
using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Database
{
    internal class PatientHistoryDB
    {
        // will add a new row to the patienthis table
        public void SaveHistory(string nic, DateTime visitDate, string amcNumber, string prescription)
        {
            SqlConnection con = DBConnection.GetConnection();

            con.Open();

            string query = "INSERT INTO PatientHistory (NIC, VisitDate, AMCNumber, Prescription) VALUES (@NIC, @VisitDate, @AMCNumber, @Prescription)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NIC", nic);
            cmd.Parameters.AddWithValue("@VisitDate", visitDate);
            cmd.Parameters.AddWithValue("@AMCNumber", amcNumber);
            cmd.Parameters.AddWithValue("@Prescription", prescription);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        // taking all history of a patient
        public DataTable GetHistory(string nic)
        {
            SqlConnection con = DBConnection.GetConnection();

            string query = "SELECT VisitDate, AMCNumber, Prescription FROM PatientHistory WHERE NIC=@NIC";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NIC", nic);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}