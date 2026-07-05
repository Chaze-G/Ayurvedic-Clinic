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
            //Application.Run(new doctor_prescription());
            // Application.Run(new Login ());
            //  Application.Run(new AdminDashboard());
            // Application.Run(new DoctorRegistor());
            //Application.Run(new Patient_registration());


            //sithmi's trail hard coded sample
            //doctor_prescription docForm = new doctor_prescription("AMC-TEST-001"); 

            //docForm.LoadPatient("200562001632c1");

            //Application.Run(docForm);



            //Application.Run(new DoctorRegistor());
            Application.Run(new Login());
            Application.Run(new AdminDashboard());


        }
    }
}


 
