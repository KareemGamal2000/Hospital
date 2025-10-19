using Hospital.BLL.Dtos.Clinic;
using Hospital.BLL.Dtos.Employee;
using Hospital.BLL.Service.ClinicService;
using Hospital.BLL.Service.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService EmployeeService)
        {
            _employeeService = EmployeeService;
        }

        [HttpGet("/GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployess()
        {
            var getEmployees = await _employeeService.GetAllEmployees();
            return Ok(getEmployees);
        }
        [HttpPost("/AddEmployee")]
        public async Task<IActionResult> AddEmployee(AddEmployeeDto empdto)
        {
            var employees = await _employeeService.add(empdto);
            return Ok(employees);

        }
    }
}
