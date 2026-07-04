using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
   public class Doctor : person
    {
        public string AMCNo { get; set; }
        public string SpecializedFor { get; set; }
        public string Gender { get; set; }
    }
}
