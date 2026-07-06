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
                prescription += "• Back Pain Care Pack\r\n";

            if (ufbut2.Checked)
                prescription += "• Bowel Care Pack\r\n";

            if (ufbut3.Checked)
                prescription += "• Cough Care Pack\r\n";

            if (ufbut4.Checked)
                prescription += "• Diabetic Care Pack\r\n";

            if (ufbut5.Checked)
                prescription += "• Digestive Care Pack\r\n";

            if (ufbut6.Checked)
                prescription += "• Fever Care Pack\r\n";

            if (ufbut7.Checked)
                prescription += "• Gastric Relief Pack\r\n";

            if (ufbut8.Checked)
                prescription += "• Skin Care Pack\r\n";

            if (ufbut9.Checked)
                prescription += "• Sleep Support Pack\r\n";

            if (ufbut10.Checked)
                prescription += "• Urinary Care Pack\r\n";

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
    }
}