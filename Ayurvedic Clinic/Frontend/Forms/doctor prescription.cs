using project_test;
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
    public partial class doctor_prescription : Form
    {
       

        public doctor_prescription()
        {
            InitializeComponent();
        }

        private void doctor_prescription_Load(object sender, EventArgs e)
        {

        }

        private void medipackbut_Click(object sender, EventArgs e)
        {

        }

        private void dpformorepatientdetailbut_Click(object sender, EventArgs e)
        {
            Patient_registration pr = new Patient_registration();
            pr.Show();
            this.Hide();
        }
            
        
    

        private void dppatienthistorybut_Click(object sender, EventArgs e)
        {

            PatientsHistory patienthis= new PatientsHistory();
            patienthis.Show();
            
        }
        

        private void dpmedipacksbut_Click(object sender, EventArgs e)
        { 
            uf uniqueform = new uf(this);
            uniqueform.Show();
        }

        private void dpsendtopharmacybut_Click(object sender, EventArgs e)
        {
            MedicalPharmacy pharmacy = new MedicalPharmacy(
                dvnametxt.Text,
                dpDatetxt.Text,
                dpagetxt.Text,
                dplmcnumbertxt.Text,
                dpallergiestxt.Text,
                dpnotestxt.Text);

            pharmacy.Show();

            this.Hide();
        }





        public void AddMedicinePack(string medicinePack)
        {
            if (!string.IsNullOrWhiteSpace(dpnotestxt.Text))
                dpnotestxt.AppendText(Environment.NewLine);
            dpnotestxt.AppendText(medicinePack);
        }

        
        
    }
}

