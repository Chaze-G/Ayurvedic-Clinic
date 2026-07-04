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

            

          
            
            mpPatientnametxt.Text = patientName;
            mpDateandtimetxt.Text = visitDate;
            mpAgetxt.Text = age;
            mpDrslmcnumbertxt.Text = doctorSLMC;
            mpAllergiestxt.Text = allergies;
            mpDescriptiontxt.Text = description;


        }

        private void mpSavebut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }






       

        
       
        private void label10_Click(object sender, EventArgs e)
        {
            // Write your code here, or leave it empty if you just want to silence the error
        }
        private void mpTB07_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
