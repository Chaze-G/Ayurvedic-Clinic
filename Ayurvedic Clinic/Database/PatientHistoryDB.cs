using Ayurvedic_Clinic.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Database
{
    public class PatientHistoryDB
    {


        //methd-to save wht dr writes 

        public void SavePrescription(string nic, string amcNumber, string prescriptionText)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
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



        //methd to show his under nic
        public DataTable GetPatientHistory(string nic)
        {
            DataTable dt = new DataTable();// creats empty tble to store 

            using (SqlConnection conn = DBConnection.GetConnection())
            {


                string query = @"SELECT HistoryID, 
                                    VisitDate, 
                                    AMCNumber, 
                                    Prescription 
                             FROM PatientHistory 
                             WHERE NIC = @NIC 
                             ORDER BY VisitDate DESC";




                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                //sqldatadapter-to fill dta from db

                da.SelectCommand.Parameters.AddWithValue("@NIC", nic);

                da.Fill(dt);


            }

            return dt;
        }
    }
}