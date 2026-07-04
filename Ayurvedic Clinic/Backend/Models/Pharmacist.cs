using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
    public class Pharmacist : Person
    {
       public string LicenseNumber { get; set; }

        public override string GetPermissions()
        {
            return "Can view prescriptiona and dispenese medicine.";
        }


    }
}
