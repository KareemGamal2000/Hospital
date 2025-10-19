using Hospital.BLL.Dtos.Doctor;
using Hospital.BLL.Service.DoctorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService DoctorsService)
        {
            _doctorService = DoctorsService;
        }

        [HttpGet("/GetAllDoctors")]
        public async Task<IActionResult> GetAllDoctors()
        {
            var Doctors = await _doctorService.GetAllDoctors();
            return Ok(Doctors);
        }
        [HttpPost("/AddDoctor")]
        public async Task<IActionResult> AddDoctor(AddDoctorDto doctorDto)
        {
            var doctors = await _doctorService.add(doctorDto);
            return Ok(doctors);

        }
    }
}
