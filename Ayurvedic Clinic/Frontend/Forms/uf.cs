using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void uf_Load(object sender, EventArgs e)
        {
            prescriptions["Back pain care pack"] = "Beheth erandu mul,Belimul,Elabatumul,Katuwelbatu,Nasnaranmul,Polpala,Gokatumul" +
                "(Take 1 kalan and 14 manchadi and put 8 water cups and boiled it into one cup and devide it into 1/2 and take a part in the morning and night for 5 day)";
            prescriptions["Bowel care pack"] = "Aralu,Bulu,Nelli (take 4 kalan and put 8 water cups and boiled it into one cup and filter it and devide it into" +
                "1/2 and take a part in morning and night for 3 days)";
            prescriptions["Cough care pack"] = "Wiyali inguru,Dewadara,Koththamalli,Elabatumul,Katuwelbatu (take 2 kalan and 8 manchadi and put 8 cup of water and boiled it into" +
                "one cup and filter it and devide it into 1/2 and take in the morning and night for 5 days)";
            prescriptions["Diabetic care pack"] = "Alukesel ala,Kothalahimbatu,Nelli,Gokatumul,Suduhandun,Bawilamul (take 2 kalan and 8 manchadi and boiled it onto one cup and " +
                "after filtering it devide into 2 parts and take each part in morning and night for 5 days)";
            prescriptions["Diegestive care pack"] = "Koththamalli,Wiyali inguru ,Kaladuru ala,Iriweriya dandu Belimul(take 2 kaln and 8 manchadi and put 8 water cups and boiled it" +
                "into one cup and take in morning and night for 5 days)";
            prescriptions["Fever care pack"] = "Suwandakottan,Rasakinda,Wiyali inguru,Iriweriyadandu,Katuwelbatu (take 2 kalan and put 8 water cups and boiled it into one cup and devide " +
                "into 1/2 parts and take each part in the morning and the night fpr 5 days)";
            prescriptions["Gastric relief pack"] = "Barly ata,Thippilimul, Dummalla dandu (take 4 kalan and put 8 cup of water and boiled it into one cup and after filtering" +
                "take in the morning and night for 5 days with  bee honey)";
            prescriptions["Skin care pack"] = "Welmada,Aralu Bulu , Nelli,Ktukroshana,Wadakaha,Dewadara,Wiyali kaha,Rasakinda,Kohomba pothu(tale 1 kalan and 4 manchadi and put 8 " +
                "cup of water and take in the morning and the night for five days)";
            prescriptions["Sleep support pack"] = "Lunuwila dandu, Gotukola (take 6 kalan take 8 water and boiled it into one cup and take in the morning and nigh)";
            prescriptions["Urinary care pack"] = "Aswenna ,Polpala,Elabatumul,Katuwelbatu (take 2 kalan and 8 manchadi and put 8 water cups and boiled it into one cup andfilter" +
                "it and devide into 1/2 and take each part in the morning and night for 5 days)";

        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            MessageBox.Show("successfully added to the prescrption", "success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(currentPackage != "")
            {
                prescriptions[currentPackage] = rtbPrescription.Text;
                MessageBox.Show("prescription saved succsessfully");
            }
        }

        private void lblBowel_Click(object sender, EventArgs e)
        {
            currentPackage = "Bowel care pack";
            rtbPrescription.Text = prescriptions["Bowel care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblBowel.BackColor = Color.LightBlue;
            lastSelectedLabel = lblBowel;
            
           
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            currentPackage = "Back pain care pack";
            rtbPrescription.Text = prescriptions["Back pain care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblBack.BackColor = Color.LightBlue;
            lastSelectedLabel = lblBack;

        }

        private void lblCough_Click(object sender, EventArgs e)
        {
            currentPackage = "Cough care pack";
            rtbPrescription.Text = prescriptions["Cough care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblCough.BackColor = Color.LightBlue;
            lastSelectedLabel = lblCough;


        }

        private void lblDiabetic_Click(object sender, EventArgs e)
        {
            currentPackage = "Diabetic care pack";
            rtbPrescription.Text = prescriptions["Diabetic care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblDiabetic.BackColor = Color.LightBlue;
            lastSelectedLabel = lblDiabetic;

        }

        private void lblDiegestive_Click(object sender, EventArgs e)
        {
            currentPackage = "Diegestive care pack";
            rtbPrescription.Text = prescriptions["Diegestive care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblDiegestive.BackColor = Color.LightBlue;
            lastSelectedLabel = lblDiegestive;

        }

        private void lblFever_Click(object sender, EventArgs e)
        {
            currentPackage = "Fever care pack";
            rtbPrescription.Text = prescriptions["Fever care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblFever.BackColor = Color.LightBlue;
            lastSelectedLabel = lblFever;

        }

        private void lblGastric_Click(object sender, EventArgs e)
        {
            currentPackage = "Gastric relief pack";
            rtbPrescription.Text = prescriptions["Gastric relief pack"]; if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblGastric.BackColor = Color.LightBlue;
            lastSelectedLabel = lblGastric;


        }

        private void lblSkin_Click(object sender, EventArgs e)
        {
            currentPackage = "Skin care pack";
            rtbPrescription.Text = prescriptions["Skin care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblBowel.BackColor = Color.LightBlue;
            lastSelectedLabel = lblSkin;

        }

        private void lblSleep_Click(object sender, EventArgs e)
        {
            currentPackage = "Sleep support pack";
            rtbPrescription.Text = prescriptions["Sleep support pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblSleep.BackColor = Color.LightBlue;
            lastSelectedLabel = lblSleep;

        }

        private void lblUrinary_Click(object sender, EventArgs e)
        {
            currentPackage = "Urinary care pack";
            rtbPrescription.Text = prescriptions["Urinary care pack"];
            if (lastSelectedLabel != null)
            {
                lastSelectedLabel.BackColor = SystemColors.Control;
            }
            lblUrinary.BackColor = Color.LightBlue;
            lastSelectedLabel = lblUrinary;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
