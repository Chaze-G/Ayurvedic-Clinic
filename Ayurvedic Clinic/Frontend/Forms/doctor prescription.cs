using Ayurvedic_Clinic.Backend.Models;
using Ayurvedic_Clinic.Database;
using project_test;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public void LoadPatient(string nic)
        {
            currentPatient = GetPatientByNIC(nic);

            if (currentPatient != null)
            {
                dvnametxt.Text = currentPatient.Name;       
                dpagetxt.Text = currentPatient.Age.ToString();
                dpallergiestxt.Text = currentPatient.Allergies ?? "None";
            }
            else
            {
                MessageBox.Show("Patient not found!");
                this.Close();
            }
        }

        private Patient GetPatientByNIC(string nic)
        {

            using (SqlConnection conn = DBConnection.GetConnection())
            
               

                {
                    string query = "SELECT * FROM Patient WHERE NIC = @NIC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Patient p = new Patient();

                        p.NIC = reader["NIC"].ToString();
                        p.Name = reader["PatientName"].ToString();

                        if (int.TryParse(reader["Age"]?.ToString(), out int age))
                            p.Age = age;

                        p.Gender = reader["Gender"]?.ToString();
                        p.Allergies = reader["Allergies"]?.ToString();

                        return p;
                    }
                }
                return null;
            }
        
        private void dpformorepatientdetailbut_Click(object sender, EventArgs e)
        {
            if (currentPatient == null)
            {
                MessageBox.Show("No patient loaded.");
                return;
            }

            Patient_registration patientRegForm = new Patient_registration();
            patientRegForm.LoadPatientForView(currentPatient.NIC);
            patientRegForm.ShowDialog();

            LoadPatient(currentPatient.NIC);   
        }

        private void dppatienthistorybut_Click(object sender, EventArgs e)
        {
            if (currentPatient == null)
            {
                MessageBox.Show("Please load a patient first.");
                return;
            }

            PatientsHistory historyForm = new PatientsHistory();
            historyForm.LoadPatientHistory(currentPatient.NIC);
            historyForm.Show();
            // this.Hide();  //later will discuss with others
        }

        private void dpmedipacksbut_Click(object sender, EventArgs e)
        {
            uf uniqueform = new uf(this);
            //this.Hide();need to confirm
            uniqueform.ShowDialog();
            this.Show();
        }

        private void dpsendtopharmacybut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dpnotestxt.Text))
            {
                MessageBox.Show("Please write the prescription before sending to pharmacy.");
                return;
            }

            if (currentPatient != null)
            {
                historyDB.SavePrescription(currentPatient.NIC, currentAMCNo, dpnotestxt.Text);
                MessageBox.Show("Prescription added to the pharmacy and updated patients History ");
                return;
            }

         
            MedicalPharmacy pharmacy = new MedicalPharmacy(
                dvnametxt.Text,
                dpDatetxt.Text,
                dpagetxt.Text,
                dplmcnumbertxt.Text,
                dpallergiestxt.Text,
                dpnotestxt.Text);

           
        }

        public void AddMedicinePack(string medicinePack)
        {
            if (!string.IsNullOrWhiteSpace(dpnotestxt.Text))
                dpnotestxt.AppendText(Environment.NewLine);
            dpnotestxt.AppendText(medicinePack);
        }

        private void doctor_prescription_Load(object sender, EventArgs e) { }
        private void medipackbut_Click(object sender, EventArgs e) { }
        private void dpnotestxt_TextChanged(object sender, EventArgs e) { }

        private void dpsavebut_Click(object sender, EventArgs e)
        {

        }

        private void dpsearchnicbut_Click(object sender, EventArgs e)
        {
            SearchID sid=new SearchID();
            sid.Show();
            this.Hide();

        }
    }
}