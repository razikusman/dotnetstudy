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
    public class AddminsController : ControllerBase
    {
        private readonly IAddminRepository _context;

        public AddminsController(IAddminRepository context)
        {
            _context = context;
        }

        // GET: api/Addmins
        [HttpGet]
        public async Task<IActionResult> GetAddmins()
        {
            return Ok(await _context.GetAllAddminAsync());
        }

        // Get: api/Addmins/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddmins(int id)
        {
            return Ok(await _context.GetAddminByIDAsync(id));
        }

        //create
        [HttpPost]
        public async Task<IActionResult> CreateAddmins([FromBody] Addmin addmin)
        {
            return Ok(await _context.CreateAddminAsync(addmin));
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddmins(int id, Addmin addmin)
        {
            if (id != addmin.AddminId)
            {
                return BadRequest();
            }
            return Ok(await _context.UpdateAddminAsync(addmin));
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddmins(int id)
        {
            return Ok(await _context.DeleteAddminByIDAsync(id));
        }
    }
}
