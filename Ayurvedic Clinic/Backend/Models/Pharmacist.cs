using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
    public class Pharmacist : person
    {
       public string LicenseNumber { get; set; }

       public string Gender { get; set; }

    }
}
