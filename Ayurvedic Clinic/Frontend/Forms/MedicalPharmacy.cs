using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ayurvedic_Clinic.Database;
using System.Data.SqlClient;

namespace Ayurvedic_Clinic.Frontend.Forms
{
    public partial class MedicalPharmacy : Form
    {
        public MedicalPharmacy()
        {
            InitializeComponent();
        }
        public MedicalPharmacy(string nic)
        {
            InitializeComponent();
            LoadPatientDetails(nic);
            LoadLatestPrescription(nic);

        }





        private void LoadPatientDetails(string nic)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"SELECT PatientName,
                                Age,
                                Allergies
                         FROM Patient
                         WHERE NIC = @NIC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NIC", nic);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mpPatientnametxt.Text = reader["PatientName"].ToString();
                    mpAgetxt.Text = reader["Age"].ToString();
                    mpAllergiestxt.Text = reader["Allergies"].ToString();
                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }
            }
        }

        private void LoadLatestPrescription(string nic)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = @"SELECT TOP 1
                                AMCNumber,
                                Prescription
                         FROM PatientHistory
                         WHERE NIC = @NIC
                         ORDER BY VisitDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NIC", nic);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mpDrslmcnumbertxt.Text = reader["AMCNumber"].ToString();
                    mpDescriptiontxt.Text = reader["Prescription"].ToString();
                }
            }
        }

        private void mpbut01_Click(object sender, EventArgs e)
        {
            SearchID search = new SearchID();
            search.Show();
            this.Close();
        }










        private void label10_Click(object sender, EventArgs e)
        {
            // Write your code here, or leave it empty if you just want to silence the error
        }
        private void mpTB07_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
