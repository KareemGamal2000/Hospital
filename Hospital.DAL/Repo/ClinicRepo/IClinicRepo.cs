using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.ClinicRepo
{
    public interface IClinicRepo
    {
        Task<IEnumerable<Entities.Clinic>> GetAllClinics();

        Task<int> Add(Entities.Clinic clinic);
    }
}
