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

            //Application.Run(new Login ());
            // Application.Run(new doctor_prescription());
            // Application.Run(new Login ());
            //  Application.Run(new AdminDashboard());
            // Application.Run(new DoctorRegistor());
            Application.Run(new Patient_registration());

           /* // === TEST DOCTOR PRESCRIPTION FORM DIRECTLY ===
            doctor_prescription docForm = new doctor_prescription("AMC-TEST-001"); // Fake AMC Number

            // Change this NIC to one that exists in your Patient table
            docForm.LoadPatient("200562001632");

            Application.Run(docForm);
*/


        }
    }
}


 
