using Ayurvedic_Clinic;
using project_test;
﻿using Ayurvedic_Clinic.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayurvedic_Clinic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Pharmacist_registration());
            Application.Run(new doctor_prescription());
           /* Application.Run(new Patient_registration());
            Application.Run(new MedicalPharmacy());
            Application.Run(new PatientsHistory());

            Application.Run(new DoctorRegistor());
            Application.Run(new ChildRegistration());

            Application.Run(new Login());
            Application.Run(new AdminDashboard());
            Application.Run(new SearchID());

        }
    }
}
