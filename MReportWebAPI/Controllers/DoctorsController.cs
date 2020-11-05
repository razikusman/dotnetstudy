using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MReportWebAPI.Interfaces;
using MReportWebAPI.Models;

namespace MReportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
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

        //create
        [HttpPost]
        public async Task<IActionResult> CreateDoctors([FromBody] Doctor doctors)
        {
            return Ok(await _context.CreateDoctorsAsync(doctors));
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctors(int id, Doctor doctors)
        {
            if (id != doctors.DoctorId)
            {
                return BadRequest();
            }
            return Ok(await _context.UpdateDoctorsAsync(doctors));
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctors(int id)
        {
            return Ok(await _context.DeleteDoctorsByIDAsync(id));
        }
    }
}
