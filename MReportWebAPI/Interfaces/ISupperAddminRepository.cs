using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Interfaces
{
    public interface ISupperAddminRepository
    {
        Task<List<SuperAddmin>> GetAllSupperAddminAsync();
        Task<SuperAddmin> GetSupperAddminByIDAsync(int id);
        Task<SuperAddmin> CreateSupperAddminAsync(SuperAddmin superAddmin);
        Task<SuperAddmin> DeleteSupperAddminByIDAsync(int id);
        Task<SuperAddmin> UpdateSupperAddminAsync(SuperAddmin superAddmin);
    }
}
