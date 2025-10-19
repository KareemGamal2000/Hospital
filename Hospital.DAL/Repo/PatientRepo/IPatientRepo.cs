using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.PatientRepo
{
    public interface IPatientRepo
    {
        Task<IEnumerable<Entities.Patient>> GetAllPatients();
        Task<int> Add(Entities.Patient patient);
    }
}
