using Hospital.BLL.Dtos.Employee;
using Hospital.BLL.Dtos.Patient;
using Hospital.BLL.Service.EmployeeService;
using Hospital.BLL.Service.PatientService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService PatientService)
        {
            _patientService = PatientService;
        }

        [HttpGet("/GetAllPatients")]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientService.GetAllPatients();
            return Ok(patients);
        }
        [HttpPost("/AddPatient")]
        public async Task<IActionResult> AddPatient(AddPatientDto patientdto)
        {
            var patients = await _patientService.add(patientdto);
            return Ok(patients);

        }
    }
}
