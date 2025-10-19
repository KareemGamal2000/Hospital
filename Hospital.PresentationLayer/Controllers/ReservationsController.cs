using Hospital.BLL.Dtos.Patient;
using Hospital.BLL.Dtos.Reservation;
using Hospital.BLL.Service.PatientService;
using Hospital.BLL.Service.ReservationService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reserveService;

        public ReservationsController(IReservationService ReserveService)
        {
            _reserveService = ReserveService;
        }

        [HttpGet("/GetAllReserves")]
        public async Task<IActionResult> GetAllReserves()
        {
            var reserves = await _reserveService.GetAllReservationd();
            return Ok(reserves);
        }
        [HttpPost("/AddReserve")]
        public async Task<IActionResult> AddReserve(AddReservationDto Reservedto)
        {
            var Reserves = await _reserveService.add(Reservedto);
            return Ok(Reserves);

        }
        [HttpDelete("/id")]
        public async Task<IActionResult> DeleteReserve(int id)
        {
            bool success = await _reserveService.Delete(id);

            return Ok(success);
        }

        
        [HttpGet("ByDoctor/{doctorId}")]
        public async Task<IActionResult> GetReservationsByDoctor(int doctorId)
        {
            var reserves = await _reserveService.GetReservationsByDoctorId(doctorId);

            return Ok(reserves);

        }
        [HttpGet("ByPatient/{patientId}")]
        public async Task<IActionResult> GetReservationsByPatient(int patientId)
        {
            var reserves = await _reserveService.GetReservationsByPatientId(patientId);
            return Ok(reserves);
        }
    }
}
