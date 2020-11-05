using Microsoft.EntityFrameworkCore;
using MReportWebAPI.Interfaces;
using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.DAL.repository
{
    public class SupperAddminRepository : ISupperAddminRepository
    {
        private readonly MReportDBContext _context;

        public SupperAddminRepository(MReportDBContext context)
        {
            _context = context;
        }
        public Task<SuperAddmin> CreateSupperAddminAsync(SuperAddmin superAddmin)
        {
            throw new NotImplementedException();
        }

        public Task<SuperAddmin> DeleteSupperAddminByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuperAddmin>> GetAllSupperAddminAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SuperAddmin> GetSupperAddminByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SuperAddmin> UpdateSupperAddminAsync(SuperAddmin superAddmin)
        {
            throw new NotImplementedException();
        }
    }
}
