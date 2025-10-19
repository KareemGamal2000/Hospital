using Hospital.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.DoctorRepo
{
    public class DoctorRepo: IDoctorRepo
    {
        private readonly ApplicationDbContext _context;

        public DoctorRepo(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Entities.Doctor>> GetAllDoctors()
        {
            return await _context.Doctors.ToListAsync();

        }
        public async Task<int> Add(Entities.Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
            return await _context.SaveChangesAsync();
        }
    }
}
