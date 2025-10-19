using Hospital.BLL.Dtos.Employee;
using Hospital.BLL.Dtos.Patient;
using Hospital.DAL.Entities;
using Hospital.DAL.Repo.EmployeeRepo;
using Hospital.DAL.Repo.PatientRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.EmployeeService
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepo _context;

        public EmployeeService(IEmployeeRepo context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetEmployeeDto>> GetAllEmployees()
        {
            var Employees = await _context.GetAllEmployeess();
            var EmployeeDto = Employees.Select(x => new GetEmployeeDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Position = x.Position,
                Salary = x.Salary,
                DateHired = x.DateHired,
                ClinicId = x.ClinicId
            });
            return EmployeeDto;
        }
        public async Task<int> add(AddEmployeeDto employeedto)
        {
            var employee = new Employee()
            {
                FirstName = employeedto.FirstName,
                LastName = employeedto.LastName,
                Position = employeedto.Position,
                Salary = employeedto.Salary,
                DateHired = employeedto.DateHired,
                ClinicId = employeedto.ClinicId
            };

            return await _context.Add(employee);
        }
    }
}
