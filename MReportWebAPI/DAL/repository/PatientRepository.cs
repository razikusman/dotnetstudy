using Microsoft.EntityFrameworkCore;
using MReportWebAPI.Interfaces;
using MReportWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportWebAPI.DAL.repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly MReportDBContext _context;

        public PatientRepository(MReportDBContext context)
        {
            _context = context;
        }

        //create
        public async Task<Patient> CreatePatientAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return patient;
        }

        //delete
        public async Task<Patient> DeletePatientAsync(int id)
        {
            var patient = await _context.Set<Patient>().FindAsync(id);
            if (patient == null)
            {
                return patient;
            }

            _context.Set<Patient>().Remove(patient);
            await _context.SaveChangesAsync();

            return patient;
        }

        //get
        public async Task<List<Patient>> GetAllPatientAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        //getById
        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _context.Patients.FirstOrDefaultAsync(patient => patient.PatientId == id);
        }

        //update
        public async Task<Patient> UpdatePatientAsync(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return patient;
        }
    }
}
