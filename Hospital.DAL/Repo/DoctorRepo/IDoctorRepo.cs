using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.DoctorRepo
{
    public interface IDoctorRepo
    {
        Task<IEnumerable<Entities.Doctor>> GetAllDoctors();

        Task<int> Add(Entities.Doctor doctor);
    }
}
