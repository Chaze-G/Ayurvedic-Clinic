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
            //Application.Run(new Patient_registration());
            Application.Run(new MedicalPharmacy());
            //Application.Run(new PatientsHistory());

            //Application.Run(new DoctorRegistor());
            //Application.Run(new ChildRegistration());

            //Application.Run(new Login());
            //Application.Run(new AdminDashboard());
            //Application.Run(new SearchID());
            //var pharmacistRegistration = new Pharmacist_registration();
            var doctorPrescription = new doctor_prescription();
            //var patientRegistration = new Patient_registration();
            var medicalPharmacy = new MedicalPharmacy();
            //var patientsHistory = new PatientsHistory();
            //var doctorRegistor = new DoctorRegistor();
            //var childRegistration = new ChildRegistration();
            //var login = new Login();
            //var adminDashboard = new AdminDashboard();

            //Application.Run(pharmacistRegistration);
            Application.Run(new uf(doctorPrescription));
            Application.Run(doctorPrescription);
            //Application.Run(patientRegistration);
            //Application.Run(medicalPharmacy);
            //Application.Run(patientsHistory);
            //Application.Run(doctorRegistor);
            //Application.Run(childRegistration);
            //Application.Run(login);
            //Application.Run(adminDashboard);
             // Pass the required argument here
        }
    }
}
