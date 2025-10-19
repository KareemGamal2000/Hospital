using Hospital.BLL.Dtos.Clinic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.ClinicService
{
    public interface IClinicService
    {
        Task<IEnumerable<GetClinicDto>> GetAllClinics();
        Task<int> add(AddClinicDto clinicdto);
    }
}
