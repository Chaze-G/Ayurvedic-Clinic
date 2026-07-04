using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
   public class Doctor : Person
    {
        public string AMCNumber { get; set; }
        public string Specilization { get; set; }

        public override string GetPermissions()
        {
            return "Can prescribe medicine, view patients and update prescriptions.";
        }
    }
}
