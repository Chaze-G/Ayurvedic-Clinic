using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayurveda_project_final
{
    public partial class SuggestionRow : UserControl
    {
        public SuggestionRow()
        {
            InitializeComponent();
            this.Margin = new Padding(0, 0, 0, 8); // gap between rows
            chkSelect1.CheckedChanged += ChkSelect1_CheckedChanged;
        }

        private void ChkSelect1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chkSelect1.Checked)
            {
                chkSelect1.BackColor = Color.LightGreen;
                chkSelect1.Text = "✓";
                chkSelect1.ForeColor = Color.DarkGreen; // <-- fixed
                chkSelect1.Font = new Font(chkSelect1.Font, FontStyle.Bold);
            }
            else
            {
                chkSelect1.BackColor = Color.MistyRose;
                chkSelect1.Text = "";
            }
        }
        public string MedicineName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string Description
        {
            get => lblDescription1.Text;
            set => lblDescription1.Text = value;
        }

        public bool IsChecked
        {
            get => chkSelect1.Checked;
            set => chkSelect1.Checked = value;
        }

        private void SuggestionRow_Load(object sender, EventArgs e)
        {

        }
    }
}