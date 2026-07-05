using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayurvedic_Clinic.Backend.Models
{
    
        internal class PatientHistory
        {
            public int HistoryID { get; set; }

            public string NIC { get; set; }

            public DateTime VisitDate { get; set; }

            public string AMCNumber { get; set; }

            public string Prescription { get; set; }
        }
    }

