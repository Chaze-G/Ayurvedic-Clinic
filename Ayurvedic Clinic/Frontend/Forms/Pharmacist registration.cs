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
    public partial class Pharmacist_registration : Form
    {
        public Pharmacist_registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        
            {
                string pharmacistName = phregnametxt.Text;
                string licenceNo = phreglicencetxt.Text;
                string contactNo = phrcontactnotxt.Text;
                string gender = phregisterdropdown.SelectedItem.ToString();

                

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "INSERT INTO Pharmacist (PharmacistName, LicenseNo, ContactNumber, Gender) " +
                                   "VALUES (@PharmacistName, @LicenseNo, @ContactNo, @Gender)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PharmacistName", pharmacistName);
                        cmd.Parameters.AddWithValue("@LicenseNo", licenceNo);
                        cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pharmacist registered successfully!");
            }
        

        private void Pharmacist_registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void phregbackbut_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void phregisterdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
