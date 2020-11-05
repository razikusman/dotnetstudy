using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public String Doctor_Status { get; set; }
        public String Doctor_Contact { get; set; }
        public String Doctor_Address { get; set; }
        public String Doctor_FirstName { get; set; }
        public String Doctor_LastName { get; set; }
        public String Doctor_Gender { get; set; }
        public String Doctor_Password { get; set; }
        public String Doctor_Email { get; set; }
        public String Doctor_Specialization { get; set; }
    }
}
