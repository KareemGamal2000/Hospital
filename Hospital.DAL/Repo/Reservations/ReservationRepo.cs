using Hospital.DAL.Context;
using Hospital.DAL.Entities;
using Hospital.DAL.Repo.Reservation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.Reservations
{
    public class ReservationRepo:IReservationRepo
    {

        private readonly ApplicationDbContext _context;

        public ReservationRepo(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Entities.Reservation>> GetAllReservation()
        {
            return await _context.Reservations.ToListAsync();

        }
        public async Task<int> Add(Entities.Reservation Reserve)
        {
            await _context.Reservations.AddAsync(Reserve);
            return await _context.SaveChangesAsync();
        }
        public async Task<bool> Delete(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return false;
            }
          

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<IEnumerable<Entities.Reservation>> GetByDoctorId(int doctorId)
        {
            return await _context.Reservations
                .Where(r => r.DoctorId == doctorId)
                .Include(r => r.Patient) 
                .ToListAsync();
        }
        public async Task<IEnumerable<Entities.Reservation>> GetByPatientId(int patientId)
        {
            return await _context.Reservations
                .Where(r => r.PatientId == patientId)
                .Include(r => r.Doctor) 
                .ToListAsync();
        }
       
    }
}
