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

            if (checkBox1.Checked)
                selectedPacks += "Back Pain Care Pack\n";

            if (checkBox2.Checked)
                selectedPacks += "Bowel Care Pack\n";

            if (checkBox3.Checked)
                selectedPacks += "Cough Care Pack\n";

            if (checkBox4.Checked)
                selectedPacks += "Diabetic Care Pack\n";

            if (checkBox5.Checked)
                selectedPacks += "Digestive Care Pack\n";

            if (checkBox6.Checked)
                selectedPacks += "Fever Care Pack\n";

            if (checkBox7.Checked)
                selectedPacks += "Gastric Relief Pack\n";

            if (checkBox8.Checked)
                selectedPacks += "Skin Care Pack\n";

            if (checkBox9.Checked)
                selectedPacks += "Sleep Support Pack\n";

            

            MessageBox.Show(selectedPacks);
        }
    }
}
