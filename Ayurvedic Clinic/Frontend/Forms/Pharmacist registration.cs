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
            Pharmacist ph = new Pharmacist();

            ph.Name = phregnametxt.Text;
            ph.LicenseNumber = phreglicencetxt.Text;
            ph.ContactNumber = phrcontactnotxt.Text;
            ph.Gender = phregisterdropdown.SelectedItem.ToString();

            PharmacistDB.SavePharmacist(ph);

            User u = new User();
            u.Username = ph.LicenseNumber;
            u.Password = phrlicencenotxt.Text;
            u.Role = "Pharmacist";

            UserDB.InsertUser(u);

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
