using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Dtos.Doctor
{
    public class AddDoctorDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Specialty { get; set; }

        public string PhoneNumber { get; set; }

        public int? ClinicId { get; set; }
    }
}
