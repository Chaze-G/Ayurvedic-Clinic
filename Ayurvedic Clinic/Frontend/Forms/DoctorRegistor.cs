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
            Doctor d = new Doctor();

            // from Person
            d.Name = drnametxt.Text;
            d.ContactNumber = drcontatcttxt.Text;

            // from Doctor
            d.AMCNo = drslmctxt.Text;
            d.SpecializedFor = drspecializedtxt.Text;

            
            if (drgendermalecheckbox.Checked)
                d.Gender = "Male";
            else if (drgenderfemalecheckbox.Checked)
                d.Gender = "Female";

            DoctorDB.SaveDoctor(d);

            MessageBox.Show("Doctor registered successfully!");
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void phbackbut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void drnametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
