using Ayurvedic_Clinic.Backend.Models;//patient cls from modls
using Ayurvedic_Clinic.Database;

using System;

using System.Data;

using System.Data.SqlClient;
using System.Windows.Forms;



namespace Ayurvedic_Clinic.Frontend.Forms
{
    
    public partial class PatientsHistory : Form
    {

        private string currentNIC;


        private PatientHistoryDB hisDB = new PatientHistoryDB();
        // privt accs modifer(encapsulation)




        public PatientsHistory()
        {
            InitializeComponent();
        }



    


        //load name to phnametxt 
          private void LoadPatientName()
        {
            string connString = "Server=(localdb)\\MSSQLLocalDB;Database=SuwasewanaDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {

                string query = "SELECT PatientName FROM Patient WHERE NIC = @NIC";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NIC", currentNIC);


                conn.Open();
                object result = cmd.ExecuteScalar();

                phnametxt.Text = result?.ToString() ?? "Unknown Patient";


            }
        } 
           
        




        //loadhis to datgrid under nic

        private void LoadHistory()
        {

            DataTable dt = hisDB.GetPatientHistory(currentNIC);//abstrction
            
            dataGridView1.DataSource = dt;

        }





        //loadname, his under current nic via declared methods-calling all
        public void LoadPatientHistory(string nic, string amcNumber = "")
        {
            currentNIC = nic;

            LoadPatientName();

            LoadHistory();

            //taking dpamctxt  hisgrid having atleast  row
            /*if (!string.IsNullOrEmpty(amcNumber) && dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Cells["AMCNumber"].Value = amcNumber;




            }*/
        }



        //closs frm but
        private void phclosebut_Click(object sender, EventArgs e)
        {


            this.Close();
        }





        

        private void phnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phnametxt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}