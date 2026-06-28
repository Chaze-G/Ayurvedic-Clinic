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
    public partial class Patient_registration : Form
    {
        public Patient_registration()
        {
            InitializeComponent();
        }

        private void Patient_registration_Load(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prbackbut_Click(object sender, EventArgs e)
        {

        }

        private void prifchildbut_Click(object sender, EventArgs e)
        {
            ChildRegistration regchild = new ChildRegistration();
            regchild.Show();

        }
    }
}
