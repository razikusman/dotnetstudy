using Microsoft.EntityFrameworkCore;
using MReportWebAPI.Interfaces;
using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.DAL
{
    public class DoctorsRepository : IDoctorRepository
    {

        private readonly MReportDBContext _context;
        public DoctorsRepository(MReportDBContext context)
        {
            _context = context;
        }

        public object Doctors => throw new NotImplementedException();

        object IDoctorRepository.Doctor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //create
        public async Task<Doctor> CreateDoctorsAsync(Doctor doctors)
        {
            _context.Doctors.Add(doctors);
            await _context.SaveChangesAsync();
            return doctors;

        }

        //delete
        public async Task<Doctor> DeleteDoctorsByIDAsync(int id)
        {
            var doctor = await _context.Set<Doctor>().FindAsync(id);
            if (doctor == null)
            {
                return doctor;
            }

            _context.Set<Doctor>().Remove(doctor);
            await _context.SaveChangesAsync();

            return doctor;
        }

        //get all
        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        //get by id
        public async Task<Doctor> GetDoctorsByIDAsync(int id)
        {
            return await _context.Doctors.FirstOrDefaultAsync(doctor => doctor.DoctorId == id);
        }

        //update
        public async Task<Doctor> UpdateDoctorsAsync(Doctor doctors)
        {
            _context.Entry(doctors).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return doctors;
        }
    }
}
