using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
   public class Doctor : person
    {
        public string AMCNumber { get; set; }
        public string Specilization { get; set; }
    }
}
