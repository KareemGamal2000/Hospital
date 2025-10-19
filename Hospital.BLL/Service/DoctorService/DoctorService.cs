using Hospital.BLL.Dtos.Doctor;
using Hospital.BLL.Dtos.Employee;
using Hospital.DAL.Entities;
using Hospital.DAL.Repo.DoctorRepo;
using Hospital.DAL.Repo.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.DoctorService
{
    public class DoctorService: IDoctorService
    {
        private readonly IDoctorRepo _context;

        public DoctorService(IDoctorRepo context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetDoctorDto>> GetAllDoctors()
        {
            var doctors = await _context.GetAllDoctors();
            var DoctorsDto = doctors.Select(x => new GetDoctorDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Specialty = x.Specialty,
                PhoneNumber = x.PhoneNumber,
                ClinicId = x.ClinicId
            });
            return DoctorsDto;
        }
        public async Task<int> add(AddDoctorDto doctordto)
        {
            var doctor = new Doctor()
            {
                FirstName = doctordto.FirstName,
                LastName = doctordto.LastName,
                Specialty = doctordto.Specialty,
                PhoneNumber = doctordto.PhoneNumber,
                ClinicId = doctordto.ClinicId
            };

            return await _context.Add(doctor);
        }
    }
}
