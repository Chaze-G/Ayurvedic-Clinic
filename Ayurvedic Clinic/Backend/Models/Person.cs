using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
    public class Person
    {
        
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public virtual string GetPermissions()

        {
            return "General User";
        }
       
    }
}

