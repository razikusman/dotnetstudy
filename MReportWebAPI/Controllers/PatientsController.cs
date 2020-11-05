using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MReportWebAPI.Interfaces;
using MReportWebAPI.Models;

namespace MReportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepository _context;
        public PatientsController(IPatientRepository context)
        {
            _context = context;
        }

        // Get: api/Patient
        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            return Ok(await _context.GetAllPatientAsync());
        }

        // Get: api/Patient/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientByID(int id)
        {
            return Ok(await _context.GetPatientByIdAsync(id));
        }

        //post
        [HttpPost]
        public async Task<IActionResult> CreatePatients([FromBody] Patient patient)
        {
            return Ok(await _context.CreatePatientAsync(patient));
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatients(int id , Patient patient)
        {
            if (id != patient.PatientId)
            {
                return BadRequest();
            }
            return Ok(await _context.UpdatePatientAsync(patient));
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatients(int id)
        {
            return Ok(await _context.DeletePatientAsync(id));
        }
    }
}
