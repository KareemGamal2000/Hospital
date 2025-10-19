using Hospital.BLL.Dtos.Reservation;
using Hospital.DAL.Entities;
using Hospital.DAL.Repo.Reservation;
using Hospital.DAL.Repo.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.ReservationService
{
    public class ReservationService: IReservationService
    {
        private readonly IReservationRepo _context;

        public ReservationService(IReservationRepo context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetReservationDto>> GetAllReservationd()
        {
            var Reservations = await _context.GetAllReservation();
            var ReserveDto = Reservations.Select(x => new GetReservationDto()
            {
                ReservationTime = x.ReservationTime,
                Status = x.Status,
                PatientId = x.PatientId,
                DoctorId = x.DoctorId,
                ClinicId= x.ClinicId
            });
            return ReserveDto;
        }

        public async Task<int> add(AddReservationDto reserveDto)
        {
            var reserve = new Reservation()
            {
                ReservationTime = reserveDto.ReservationTime,
                Status = reserveDto.Status,
                PatientId = reserveDto.PatientId,
                DoctorId = reserveDto.DoctorId,
                ClinicId = reserveDto.ClinicId
            };

            return await _context.Add(reserve);
        }
        public async Task<bool> Delete(int id)
        {
            return await _context.Delete(id);
        }
        public async Task<IEnumerable<GetReservationDto>> GetReservationsByDoctorId(int doctorId)
        {
            var Reservations = await _context.GetByDoctorId(doctorId);

            var ReserveDto = Reservations.Select(x => new GetReservationDto()
            {
                ReservationTime = x.ReservationTime,
                Status = x.Status,
                PatientId = x.PatientId,
                DoctorId = x.DoctorId,
                ClinicId = x.ClinicId

            });
            return ReserveDto;
        }
        public async Task<IEnumerable<GetReservationDto>> GetReservationsByPatientId(int patientId)
        {
            var Reservations = await _context.GetByPatientId(patientId);

            var ReserveDto = Reservations.Select(x => new GetReservationDto()
            {
                ReservationTime = x.ReservationTime,
                Status = x.Status,
                PatientId = x.PatientId,
                DoctorId = x.DoctorId,
                ClinicId = x.ClinicId
            });
            return ReserveDto;
        }
    }
}
