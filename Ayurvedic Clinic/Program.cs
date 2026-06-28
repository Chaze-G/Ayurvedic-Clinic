using Ayurvedic_Clinic;
using project_test;
using Ayurvedic_Clinic.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayurvedic_Clinic
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new Login ());
            Application.Run(new doctor_prescription());
           Application.Run(new Login ());
            Application.Run(new AdminDashboard());
        }
    }
}


 
