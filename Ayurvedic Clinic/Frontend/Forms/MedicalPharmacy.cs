using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Ayurvedic_Clinic.Database;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayurvedic_Clinic.Frontend.Forms
{
    public partial class MedicalPharmacy : Form
    {
        public MedicalPharmacy()
        {
            InitializeComponent();
        }

        public MedicalPharmacy(
            string patientName,
            string visitDate,
            string age,
            string doctorSLMC,
            string allergies,
            string description)
        {
            InitializeComponent();

            

            mpTB01.Text = patientName;
            mpTB08.Text = visitDate;
            mpTB03.Text = age;
            mpTB09.Text = doctorSLMC;
            mpTB06.Text = allergies;
            mpTB07.Text = description;
        }








        private void mpbut01_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"INSERT INTO MedicalPharmacy
                            (PatientID, DoctorID, Description, VisitDate)
                            VALUES
                            (@PatientID, @DoctorID, @Description, @VisitDate)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    // Temporary IDs until Patient Search is completed
                    cmd.Parameters.AddWithValue("@PatientID", 1);
                    cmd.Parameters.AddWithValue("@DoctorID", 1);

                    cmd.Parameters.AddWithValue("@Description", mpDescriptiontxt.Text);
                    cmd.Parameters.AddWithValue("@VisitDate", DateTime.Now);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record saved successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Clear only the description box
                    mpDescriptiontxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        private void mpTB07_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
