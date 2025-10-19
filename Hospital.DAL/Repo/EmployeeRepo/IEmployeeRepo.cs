using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.EmployeeRepo
{
    public interface IEmployeeRepo
    {
        Task<IEnumerable<Entities.Employee>> GetAllEmployeess();

        Task<int> Add(Entities.Employee employee);
    }
}
