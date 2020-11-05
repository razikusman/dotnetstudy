using Microsoft.EntityFrameworkCore;
using MReportWebAPI.Interfaces;
using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.DAL
{
    public class AddminRepository : IAddminRepository
    {
        private readonly MReportDBContext _context;

        public AddminRepository(MReportDBContext context)
        {
            _context = context;
        }
        public Task<Addmin> CreateAddminAsync(Addmin addmin)
        {
            throw new NotImplementedException();
        }

        public Task<Addmin> DeleteAddminByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Addmin> GetAddminByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Addmin>> GetAllAddminAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Addmin> UpdateAddminAsync(Addmin addmin)
        {
            throw new NotImplementedException();
        }
    }
}
