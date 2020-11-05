using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.Interfaces
{
    public interface IPatientRepository
    {
        Task<List<Patient>> GetAllPatientAsync();
        Task<Patient> GetPatientByIdAsync(int id);
        Task<Patient> CreatePatientAsync(Patient patient);
        Task<Patient> UpdatePatientAsync(Patient patient);
        Task<Patient> DeletePatientAsync(int id);
    }
}
