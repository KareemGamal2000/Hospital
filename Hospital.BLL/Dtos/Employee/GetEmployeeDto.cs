using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Dtos.Employee
{
    public class GetEmployeeDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public DateTime DateHired { get; set; }

        public decimal Salary { get; set; }

        public int? ClinicId { get; set; }
    }
}
