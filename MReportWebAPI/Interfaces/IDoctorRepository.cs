using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Interfaces
{
    public interface IDoctorRepository
    {
        object Doctor { get; set; }

        Task<List<Doctor>> GetAllDoctorsAsync();
        Task<Doctor> GetDoctorsByIDAsync(int id);
        Task<Doctor> CreateDoctorsAsync(Doctor doctors);
        Task<Doctor> DeleteDoctorsByIDAsync(int id);
        Task<Doctor> UpdateDoctorsAsync(Doctor doctors);
    }
}
