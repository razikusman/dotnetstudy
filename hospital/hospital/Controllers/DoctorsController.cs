using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hospital.Models;
using hospital.Dal;
using System.Diagnostics.Eventing.Reader;
using hospital.Interfaces;

namespace hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : Controller
    {
        private readonly IDoctorRepository _context;

        public DoctorsController(IDoctorRepository context)
        {
            _context = context;
        }

        // GET: api/Doctors
        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            return Ok(await _context.GetAllDoctorsAsync());
        }

        // Get: api/Doctors/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctors(int id)
        {
            return Ok(await _context.GetDoctorsByIDAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctors([FromBody] Doctors doctors)
        {
            return Ok(await _context.CreateDoctorsAsync(doctors));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctors(int id , Doctors doctors)
        {
            if (id != doctors.DoctorsId)
            {
                return BadRequest();
            }
            return Ok(await _context.UpdateDoctorsAsync(doctors));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctors(int id)
        {
            return Ok(await _context.DeleteDoctorsByIDAsync(id));
        }
        
    }
}

