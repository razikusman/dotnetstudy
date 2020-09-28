using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wetherforecast.Models;

namespace Wetherforecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Publisher> Get()
        {
            //CRUD
            using (var _context =new BookStoresDBContext())
            {

                //add data

                 Publisher publisher = new Publisher();
                 publisher.PublsherName = " Egmont Book ";

                 _context.Publishers.Add(publisher);
                 _context.SaveChanges();

                //update data
                /*Publisher publisher = _context.Publishers.FirstOrDefault();*/

                /*publisher.PublsherName = " Egmont Books";*/

                //delete data
                /*_context.Publishers.Remove(publisher);*/

                //save changes
               /* _context.SaveChanges();*/

                //read data
                return _context.Publishers.ToList();

            }

            
        }
    }
}
