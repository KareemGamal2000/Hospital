using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.Reservation
{
    public interface IReservationRepo
    {
        Task<IEnumerable<Entities.Reservation>> GetAllReservation();

        Task<int> Add(Entities.Reservation Reserve);
        Task<bool> Delete(int id);
        Task<IEnumerable<Entities.Reservation>> GetByDoctorId(int doctorId);
        Task<IEnumerable<Entities.Reservation>> GetByPatientId(int patientId);
    }
}
