using Hospital.BLL.Dtos.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.DoctorService
{
    public interface IDoctorService
    {
        Task<IEnumerable<GetDoctorDto>> GetAllDoctors();

        Task<int> add(AddDoctorDto doctordto);
    }
}
