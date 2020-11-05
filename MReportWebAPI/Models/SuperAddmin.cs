using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Models
{
    public class SuperAddmin
    {
        public int SuperAddminId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Active { get; set; }
        public int Contact { get; set; }
    }
}
