using Hospital.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.ClinicRepo
{
    public class ClinicRepo: IClinicRepo
    {
        private readonly ApplicationDbContext _context;

        public ClinicRepo(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Entities.Clinic>> GetAllClinics()
        {
            return await _context.Clinics.ToListAsync();

        }
        public async Task<int> Add(Entities.Clinic clinic)
        {
            await _context.Clinics.AddAsync(clinic);
            return await _context.SaveChangesAsync();
        }
    }
}
