using Ayurvedic_Clinic.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayurvedic_Clinic.Frontend.Forms
{
    public partial class SearchID : Form
    {
        public SearchID()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nic = txtPatientID.Text;

            if (Session.Role == "Doctor")
            {
                MessageBox.Show("Doctor logged in - opening prescription form");

                doctor_prescription form = new doctor_prescription(Session.Username);
                form.Show();
                this.Hide();
            }
            else if (Session.Role == "Pharmacist")
            {
                MedicalPharmacy form = new MedicalPharmacy();
                form.Show();
                this.Hide();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
