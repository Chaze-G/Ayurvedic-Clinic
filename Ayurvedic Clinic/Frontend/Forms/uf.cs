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
        Dictionary <string, string> prescriptions= new Dictionary <string, string> ();
        string currentPackage = "";
        Label lastSelectedLabel = null;
        public uf()
        {
            InitializeComponent();
        }

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IbIPackName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string selectedPacks = "";

            if (ufbut2.Checked)
                selectedPacks += "Back Pain Care Pack\n";

            if (ufbut3.Checked)
                selectedPacks += "Bowel Care Pack\n";

            if (ufbut4.Checked)
                selectedPacks += "Cough Care Pack\n";

            if (ufbut5.Checked)
                selectedPacks += "Diabetic Care Pack\n";

            if (ufbut6.Checked)
                selectedPacks += "Digestive Care Pack\n";

            if (ufbut7.Checked)
                selectedPacks += "Fever Care Pack\n";

            if (ufbut8.Checked)
                selectedPacks += "Gastric Relief Pack\n";

            if (ufbut9.Checked)
                selectedPacks += "Skin Care Pack\n";

            if (ufbut10.Checked)
                selectedPacks += "Sleep Support Pack\n";

            

            MessageBox.Show(selectedPacks);
        }

        
            private void btnAddPrescription2_Click(object sender, EventArgs e)
        {
            string prescription = "";

            if (ufbut1.Checked)
                prescription += "• Back Pain Care Pack\n";

            if (ufbut2.Checked)
                prescription += "• Bowel Care Pack\n";

            if (ufbut3.Checked)
                prescription += "• Cough Care Pack\n";

            if (ufbut4.Checked)
                prescription += "• Diabetic Care Pack\n";

            if (ufbut5.Checked)
                prescription += "• Digestive Care Pack\n";

            if (ufbut6.Checked)
                prescription += "• Fever Care Pack\n";

            if (ufbut7.Checked)
                prescription += "• Gastric Relief Pack\n";

            if (ufbut8.Checked)
                prescription += "• Skin Care Pack\n";

            if (ufbut9.Checked)
                prescription += "• Sleep Support Pack\n";

            if (ufbut10.Checked)
                prescription += "• Urinary Care Pack\n";

            if (prescription == "")
            {
                MessageBox.Show("Please select at least one medicine pack.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Prescription:\n\n" + prescription,
                                "Selected Medicine Packs",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void uf_Load(object sender, EventArgs e)
        {

        }

        private void ufbut1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

