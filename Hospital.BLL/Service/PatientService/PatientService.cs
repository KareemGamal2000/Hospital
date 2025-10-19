using Hospital.BLL.Dtos.Patient;
using Hospital.BLL.Dtos.Reservation;
using Hospital.DAL.Entities;
using Hospital.DAL.Repo.PatientRepo;
using Hospital.DAL.Repo.Reservation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Service.PatientService
{
    public class PatientService: IPatientService
    {
        private readonly IPatientRepo _context;

        public PatientService(IPatientRepo context)
        {
            _context = context;

        }
        public async Task<IEnumerable<GetPatientDto>> GetAllPatients()
        {
            var Patients = await _context.GetAllPatients();
            var PatientsDto = Patients.Select(x => new GetPatientDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth = x.DateOfBirth,
                Phone = x.Phone
            });
            return PatientsDto;
        }
        public async Task<int> add(AddPatientDto patientDto)
        {
            var patient = new Patient()
            {
                FirstName = patientDto.FirstName,
                LastName = patientDto.LastName,
                DateOfBirth = patientDto.DateOfBirth,
                Phone = patientDto.Phone
            };

            return await _context.Add(patient);
        }
    }
}

