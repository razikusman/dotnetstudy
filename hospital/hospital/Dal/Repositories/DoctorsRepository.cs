using hospital.Interfaces;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospital.Dal.Repositories
{
    public class DoctorsRepository : IDoctorRepository
    {

        private readonly HospitalDBContext _context;
        public DoctorsRepository(HospitalDBContext context)
        {
            _context = context;
        }

        public object Doctors => throw new NotImplementedException();

        object IDoctorRepository.Doctors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //create
        public async Task<Doctors> CreateDoctorsAsync(Doctors doctors)
        {
            _context.Doctors.Add(doctors);
            await _context.SaveChangesAsync();
            return doctors;

        }

        //delete
        public async Task<Doctors> DeleteDoctorsByIDAsync(int id)
        {
            var doctor = await _context.Set<Doctors>().FindAsync(id);
            if (doctor == null)
            {
                return doctor;
            }

            _context.Set<Doctors>().Remove(doctor);
            await _context.SaveChangesAsync();

            return doctor;
        }

        //get all
        public async Task<List<Doctors>> GetAllDoctorsAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        //get by id
        public async Task<Doctors> GetDoctorsByIDAsync(int id)
        {
            return await _context.Doctors.FirstOrDefaultAsync(doctor => doctor.DoctorsId == id);
        }

        //update
        public async Task<Doctors> UpdateDoctorsAsync(Doctors doctors)
        {
            _context.Entry(doctors).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return doctors;
        }
    }
}
