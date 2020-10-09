using hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Interfaces
{
    public interface IDoctorRepository
    {
        public object Doctors { get; set; }

        Task<List<Doctors>> GetAllDoctorsAsync ();
        Task<Doctors> GetDoctorsByIDAsync (int id);
        Task<Doctors> CreateDoctorsAsync (Doctors doctors);
        Task<Doctors> DeleteDoctorsByIDAsync(int id);
        Task<Doctors> UpdateDoctorsAsync(Doctors doctors);
    }
}
