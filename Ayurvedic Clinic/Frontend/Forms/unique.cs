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
    public partial class Form1 : Form
    {
        private List<SuggestionRow> rows = new List<SuggestionRow>();

        public Form1()
        {
            InitializeComponent();
            LoadSuggestions();
        }

        private void LoadSuggestions()
        {
            
            var suggestions = new List<(string Name, string Description)>
        {
            ("Maleria", "Mosquito-borne infectious disease"),
            ("Dengue", "Viral infection spread by Aedes mosquitoes"),
            ("Typhoid", "Bacterial infection from contaminated food/water"),
            ("Pneumonia", "Infection causing inflammation in the lungs"),
            ("Tuberculosis", "Bacterial infection affecting the lungs"),
            ("Hepatitis A", "Liver infection spread via contaminated food/water"),
            ("Chickenpox", "Viral infection causing itchy blisters"),
            ("Measles", "Highly contagious viral infection")
        };

            foreach (var item in suggestions)
            {
                var row = new SuggestionRow
                {
                    MedicineName = item.Name,
                    Description = item.Description
                };

                rows.Add(row);
                flpSuggestions.Controls.Add(row);
            }
            
        }

        private void btnAddToPrescription_Click(object sender, EventArgs e)
        {
            var selected = rows.Where(r => r.IsChecked)
                                .Select(r => r.MedicineName)
                                .ToList();

            if (selected.Count == 0)
            {
                MessageBox.Show("Please select at least one item.", "No selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Added to prescription:\n" + string.Join("\n", selected),
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            
        }

        private void lnkSeeMore_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Load more suggestions here (e.g. next page from DB).");
        }
    }
}
