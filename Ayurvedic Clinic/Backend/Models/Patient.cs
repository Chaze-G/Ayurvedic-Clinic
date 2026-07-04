using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
   
   

    public class Patient : Person
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Allergies { get; set; }

        public string NIC { get; set; }

        public override string GetPermissions()
        {
            return "Can register and view personal medical history.";
        }

    
    
        
    }

