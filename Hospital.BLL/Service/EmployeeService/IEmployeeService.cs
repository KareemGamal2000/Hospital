using Hospital.BLL.Dtos.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.EmployeeService
{
    public interface IEmployeeService
    {
        Task<IEnumerable<GetEmployeeDto>> GetAllEmployees();

        Task<int> add(AddEmployeeDto employeedto);
    }
}
