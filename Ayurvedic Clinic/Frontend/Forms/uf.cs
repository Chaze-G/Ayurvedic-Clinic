using Ayurvedic_Clinic.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace project_test
{
    public partial class uf : Form
    {
        private doctor_prescription prescriptionForm;

        public uf()
        {
            InitializeComponent();
        }

        public uf(doctor_prescription form)
        {
            InitializeComponent();
            prescriptionForm = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IbIPackName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPrescription2_Click(object sender, EventArgs e)
        {
            string prescription = "";

            if (ufbut1.Checked)
                prescription += "• Beheth erandu mul,Belimul,Elabatumul,Katuwelbatu,Nasnaranmul,Polpala,Gokatumul\r\n\r\n";

            if (ufbut2.Checked)
                prescription += "• Aralu,Bulu,Nelli\r\n";

            if (ufbut3.Checked)
                prescription += "• Wiyali inguru,Dewadara,Koththamalli,Elabatumul,Katuwelbatu\r\n\r\n";

            if (ufbut4.Checked)
                prescription += "• Alukesel ala,Kothalahimbatu,Nelli,Gokatumul,Suduhandun,Bawilamu\r\n";

            if (ufbut5.Checked)
                prescription += "• Koththamalli,Wiyali inguru ,Kaladuru ala,Iriweriya dandu Belimu\r\n";

            if (ufbut6.Checked)
                prescription += "• Suwandakottan,Rasakinda,Wiyali inguru,Iriweriyadandu,Katuwelbatu\r\n";

            if (ufbut7.Checked)
                prescription += "• Barly ata,Thippilimul, Dummalla dandu\r\n";

            if (ufbut8.Checked)
                prescription += "• Welmada,Aralu Bulu , Nelli,Ktukroshana,Wadakaha,Dewadara,Wiyali kaha,Rasakinda,Kohomba pothu\r\n";

            if (ufbut9.Checked)
                prescription += "• Lunuwila dandu, Gotukola\r\n";

            if (ufbut10.Checked)
                prescription += "• Aswenna ,Polpala,Elabatumul,Katuwelbatu \r\n";

            if (prescription == "")
            {
                MessageBox.Show("Please select at least one medicine pack.");
                return;
            }

            if (prescriptionForm != null)
            {
                prescriptionForm.AddMedicinePack(prescription);
            }

            MessageBox.Show("Packs added successfully!");
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalPharmacy form2 = new Ayurvedic_Clinic.Frontend.Forms.MedicalPharmacy();
            form2.Show();
        }

        private void uf_Load(object sender, EventArgs e)
        {

        }

        private void ufbut1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void phbackbut_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void IbIMedicines_Click(object sender, EventArgs e)
        {

        }
    }
}