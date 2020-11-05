using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Models
{
    public class Addmin
    {
        public int AddminId { get; set; }
        public String HospitalArea { get; set; }
        public String Email { get; set; }
        public int Contact { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String OTP { get; set; }
        public String OwnerNIC { get; set; }
    }
}
