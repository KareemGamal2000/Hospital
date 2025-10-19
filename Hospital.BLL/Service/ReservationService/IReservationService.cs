using Hospital.BLL.Dtos.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.ReservationService
{
    public interface IReservationService
    {
        Task<IEnumerable<GetReservationDto>> GetAllReservationd();
        Task<int> add(AddReservationDto reserveDto);
        Task<bool> Delete(int id);
        Task<IEnumerable<GetReservationDto>> GetReservationsByDoctorId(int doctorId);
        Task<IEnumerable<GetReservationDto>> GetReservationsByPatientId(int patientId);
    }
}

