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
    public class SupperAddminsController : ControllerBase
    {
        private readonly ISupperAddminRepository _context;
        public SupperAddminsController(ISupperAddminRepository context)
        {
            _context = context;
        }

        // Get: api/SupperAddmin
        [HttpGet]
        public async Task<IActionResult> GetAllSupperAddmin()
        {
            return Ok(await _context.GetAllSupperAddminAsync());
        }

        // Get: api/SupperAddmin/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupperAddminByID(int id)
        {
            return Ok(await _context.GetSupperAddminByIDAsync(id));
        }

        //post
        [HttpPost]
        public async Task<IActionResult> CreateSupperAddmin([FromBody] SuperAddmin superAddmin)
        {
            return Ok(await _context.CreateSupperAddminAsync(superAddmin));
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSupperAddmin(int id , SuperAddmin superAddmin)
        {
            if (id != superAddmin.SuperAddminId)
            {
                return BadRequest();
            }
            return Ok(await _context.UpdateSupperAddminAsync(superAddmin));
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupperAddmin(int id)
        {
            return Ok(await _context.DeleteSupperAddminByIDAsync(id));
        }
    }
}
