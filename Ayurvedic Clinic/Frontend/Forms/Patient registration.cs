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
    public partial class Patient_registration : Form
    {
        public Patient_registration()
        {
            InitializeComponent();
        }

        private void Patient_registration_Load(object sender, EventArgs e)
        {

        }

        private void prgenderdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void prnextbut_Click(object sender, EventArgs e)
        {

        }

        private void prsavebut_Click(object sender, EventArgs e)
        {


            string nic = prnictxt.Text;
            string patientName = prnametxt.Text;
            string contactNo = prcnumbertxt.Text;
            string address = praddresstxt.Text;
            string gender = prgenderdropdown.SelectedItem.ToString();
            int age = int.Parse(pragetxt.Text);
            string allergies = prallergiestxt.Text;

            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO Patient (NIC, PatientName, ContactNumber, Address, Gender, Age, Allergies, GuardianNIC) " +
                               "VALUES (@NIC, @PatientName, @ContactNumber, @Address, @Gender, @Age, @Allergies, NULL)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NIC", nic);
                    cmd.Parameters.AddWithValue("@PatientName", patientName);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNo);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Allergies", allergies);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Adult Patient registered successfully!");



        }

        private void label1_Click(object sender, EventArgs e)
        { 

        }

        private void prbackbut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void prifchildbut_Click(object sender, EventArgs e)
        {
            ChildRegistration regchild = new ChildRegistration();
            regchild.Show();

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pragetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
