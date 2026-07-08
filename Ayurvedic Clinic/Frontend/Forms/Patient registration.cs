using Ayurvedic_Clinic.Backend.Models;
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
using System.Xml.Linq;

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
            Patient p = new Patient();

            // from Person 
            //Inheritance used
            p.Name = prnametxt.Text;
            p.ContactNumber = prcnumbertxt.Text;

            // from Patient (child class)
            p.NIC = prnictxt.Text;
            p.Age = int.Parse(pragetxt.Text);
            p.Gender = prgenderdropdown.SelectedItem.ToString();
            p.Allergies = prallergiestxt.Text;
            p.Address= praddresstxt.Text;
            
            PatientDB.SavePatient(p);

            MessageBox.Show("Patient registered successfully!");
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



        public void LoadPatientForView(string nic)
        {
            string connString = "Server=(localdb)\\MSSQLLocalDB;Database=SuwasewanaDB;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Patient WHERE NIC = @NIC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NIC", nic);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    prnictxt.Text = reader["NIC"].ToString();
                    prnametxt.Text = reader["PatientName"].ToString();
                    pragetxt.Text = reader["Age"].ToString();
                    prcnumbertxt.Text = reader["ContactNumber"]?.ToString() ?? "";
                    praddresstxt.Text = reader["Address"]?.ToString() ?? "";
                    prallergiestxt.Text = reader["Allergies"]?.ToString() ?? "";

                    string gender = reader["Gender"]?.ToString();
                    if (!string.IsNullOrEmpty(gender) && prgenderdropdown.Items.Contains(gender))
                    {
                        prgenderdropdown.SelectedItem = gender;
                    }
                }
                else
                {
                    MessageBox.Show("Patient not found!");
                    return;
                }
            }

        
            prnictxt.ReadOnly = true;
            prnametxt.ReadOnly = true;
            pragetxt.ReadOnly = true;
            prcnumbertxt.ReadOnly = true;
            praddresstxt.ReadOnly = true;
            prallergiestxt.ReadOnly = true;
            prgenderdropdown.Enabled = false;

            
            this.Text = "Patient Full Details - View Only";
            prsavebut.Visible = false;           // Hide Save button
            prifchildbut.Visible = false;        // Hide Child button

            //back  button changes
            prbackbut.Text = "Close";
        }
    }
}
