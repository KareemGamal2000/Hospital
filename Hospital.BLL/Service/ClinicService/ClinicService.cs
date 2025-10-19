using Hospital.BLL.Dtos.Clinic;
using Hospital.BLL.Dtos.Doctor;
using Hospital.DAL.Entities;
using Hospital.DAL.Repo.ClinicRepo;
using Hospital.DAL.Repo.DoctorRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.ClinicService
{
    public class ClinicService: IClinicService
    {
        private readonly IClinicRepo _context;

        public ClinicService(IClinicRepo context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetClinicDto>> GetAllClinics()
        {
            var clinics = await _context.GetAllClinics();
            var ClinicsDto = clinics.Select(x => new GetClinicDto()
            {
                Name = x.Name,
                Location = x.Location
            });
            return ClinicsDto;
        }
        public async Task<int> add(AddClinicDto clinicdto)
        {
            var clinic = new Clinic()
            {
                Name = clinicdto.Name,
                Location = clinicdto.Location
            };

            return await _context.Add(clinic);
        }
    }
}
