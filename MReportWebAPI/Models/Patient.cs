using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public String GuardName { get; set; }
        public int GuardContact { get; set; }
        public String GuardType { get; set; }
        public int PatientContact { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String arae { get; set; }
        public String Gender { get; set; }
        public String Status { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PatientAddress { get; set; }
        public String GuardEmail { get; set; }

    }
}
