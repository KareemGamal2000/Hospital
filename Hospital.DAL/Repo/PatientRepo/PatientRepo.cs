using Hospital.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.PatientRepo
{
    public class PatientRepo: IPatientRepo
    {
        private readonly ApplicationDbContext _context;

        public PatientRepo(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Entities.Patient>> GetAllPatients()
        {
            return await _context.Patients.ToListAsync();

        }
        public async Task<int> Add(Entities.Patient patient)
        {
            await _context.Patients.AddAsync(patient);
            return await _context.SaveChangesAsync();
        }
    }
}
