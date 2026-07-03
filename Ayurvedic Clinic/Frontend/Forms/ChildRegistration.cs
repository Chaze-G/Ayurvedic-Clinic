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
    public partial class ChildRegistration : Form
    {
        public ChildRegistration()
        {
            InitializeComponent();
        }

        private void ChildRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void crguardianidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void drbackbut_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void crenterbut_Click(object sender, EventArgs e)
        {
            {
                string nicchild = crnicchildnotxt.Text;
                string patientName = crnametxt.Text;
                string contactNo = crcontctnumbertxt.Text;
                string address = cradresstxt.Text;
                int age = int.Parse(cragetxt.Text);
                string allergies = crallergiestxt.Text;
                string guardianNIC = crguardiannictxt.Text;


                string gender = "";

                if (crgendermaleradiobut.Checked)
                {
                    gender = "Male";
                }
                else if (crgenderfemaleradiobut.Checked)
                {
                    gender = "Female";
                }

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "INSERT INTO Patient (NIC, PatientName, ContactNumber, Address, Gender, Age, Allergies, GuardianNIC) " +
                                   "VALUES (@NIC, @PatientName, @ContactNumber, @Address, @Gender, @Age, @Allergies, @GuardianNIC)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@NIC", nicchild);
                        cmd.Parameters.AddWithValue("@PatientName", patientName);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNo);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Allergies", allergies);
                        cmd.Parameters.AddWithValue("@GuardianNIC", guardianNIC);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Child Patient registered successfully!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
