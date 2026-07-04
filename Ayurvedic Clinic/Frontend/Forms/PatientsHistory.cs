using Ayurvedic_Clinic.Backend.Models;   
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ayurvedic_Clinic.Frontend.Forms
{
    public partial class PatientsHistory : Form
    {
        private string currentNIC;
        private PatientHistoryDB historyDB = new PatientHistoryDB();

        public PatientsHistory()
        {
            InitializeComponent();
        }

        public void LoadPatientHistory(string nic)
        {
            currentNIC = nic;
            LoadPatientName();
            LoadHistory();
        }

        
          private void LoadPatientName()
        {
            string connString = @"Server=.\SQLEXPRESS;Database=SuwasewanaDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT PatientName FROM Patient WHERE NIC = @NIC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NIC", currentNIC);

                conn.Open();
                object result = cmd.ExecuteScalar();
                phnametxt.Text = result?.ToString() ?? "Unknown Patient";
            }
        } 
           
        

        private void LoadHistory()
        {
            DataTable dt = historyDB.GetPatientHistory(currentNIC);   // Use your DB class
            dataGridView1.DataSource = dt;
        }

        private void phclosebut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phbackbut_Click(object sender, EventArgs e)
        {

        }
    }
}