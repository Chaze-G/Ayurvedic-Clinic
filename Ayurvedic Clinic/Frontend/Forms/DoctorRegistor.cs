using Ayurvedic_Clinic.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayurvedic_Clinic.Frontend.Forms
{
    public partial class DoctorRegistor : Form
    {
        public DoctorRegistor()
        {
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void drregisterbut_Click(object sender, EventArgs e)
        {
            string doctorName = drnametxt.Text;
            string amcNo = dramctxt.Text;
            string specializedFor = drspecializedtxt.Text;
            string contactNo = drcontatcttxt.Text;

            string gender = "";

            if (drgendermalecheckbox.Checked)
            {
                gender = "Male";
            }
            else if (drgenderfemalecheckbox.Checked)
            {
                gender = "Female";
            }

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO Doctor (DoctorName, AMCNo, SpecializedFor, ContactNumber, Gender) " +
                               "VALUES (@DoctorName, @AMCNo, @SpecializedFor, @ContactNo, @Gender)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DoctorName", doctorName);
                    cmd.Parameters.AddWithValue("@AMCNo", amcNo);
                    cmd.Parameters.AddWithValue("@SpecializedFor", specializedFor);
                    cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Doctor registered successfully!");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void phbackbut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
