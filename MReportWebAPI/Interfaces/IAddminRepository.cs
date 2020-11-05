using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Interfaces
{
    public interface IAddminRepository
    {
        Task<List<Addmin>> GetAllAddminAsync();
        Task<Addmin> GetAddminByIDAsync(int id);
        Task<Addmin> CreateAddminAsync(Addmin addmin);
        Task<Addmin> DeleteAddminByIDAsync(int id);
        Task<Addmin> UpdateAddminAsync(Addmin addmin);
    }
}
