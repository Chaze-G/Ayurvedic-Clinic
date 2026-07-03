
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Ayurvedic_Clinic.Backend.Models;      
using Ayurvedic_Clinic.Database;


namespace Ayurvedic_Clinic.Frontend.Forms
{
    public partial class doctor_prescription : Form
    {
        private Patient currentPatient;
        private string currentAMCNo;
        private PatientHistoryDB historyDB = new PatientHistoryDB();

        public doctor_prescription(string amcNo)
        {
            InitializeComponent();
            currentAMCNo = amcNo;
        }
        /*public void LoadPatient(string nic)
        {
            currentPatient = GetPatientByNIC(nic);

            if (currentPatient != null)
            {
                lblName.Text = currentPatient.PatientName;
                lblAge.Text = currentPatient.Age.ToString();
                lblAllergies.Text = currentPatient.Allergies ?? "None";
            }
            else
            {
                MessageBox.Show("Patient not found!");
                this.Close();
            }
        }*/
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
            this.Hide();
        }
        

        private void dpmedipacksbut_Click(object sender, EventArgs e)
        {

          
            /*uf uniqueform = new uf(this);
            this.Hide();
            uniqueform.ShowDialog();   
            this.Show();  */            
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

        private void dpnotestxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

