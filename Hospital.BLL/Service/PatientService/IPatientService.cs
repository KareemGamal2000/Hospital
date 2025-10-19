using Hospital.BLL.Dtos.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.PatientService
{
    public interface IPatientService
    {
        Task<IEnumerable<GetPatientDto>> GetAllPatients();

        Task<int> add(AddPatientDto patientDto);
    }
}
