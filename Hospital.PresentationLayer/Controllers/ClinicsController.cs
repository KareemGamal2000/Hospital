using Hospital.BLL.Dtos.Clinic;
using Hospital.BLL.Dtos.Doctor;
using Hospital.BLL.Service.ClinicService;
using Hospital.BLL.Service.DoctorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicsController(IClinicService ClinicssService)
        {
            _clinicService = ClinicssService;
        }

        [HttpGet("/GetAllClinics")]
        public async Task<IActionResult> GetAllClinics()
        {
            var Clinics = await _clinicService.GetAllClinics();
            return Ok(Clinics);
        }
        [HttpPost("/AddClinic")]
        public async Task<IActionResult> AddDoctor(AddClinicDto clinicdto)
        {
            var clinics = await _clinicService.add(clinicdto);
            return Ok(clinics);

        }
    }
}
