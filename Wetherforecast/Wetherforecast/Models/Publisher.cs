using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wetherforecast.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public String PublsherName { get; set; }
    }
}
