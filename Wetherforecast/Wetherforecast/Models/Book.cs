using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wetherforecast.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public String Title { get; set; }

        //public String MainTitle { get; set; }
        //public String SubTitle { get; set; }
    }
}

//add-migration <name blabla> will create a migration
//update-database will add the table
//remove migration will delete the last migration
//update-database <name of the migration > will remove all the table created ater thhe stated migration but not the migration
//script-migration will create sql scipt aoo all the thin done 