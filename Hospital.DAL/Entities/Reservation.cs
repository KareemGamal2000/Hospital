using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationTime { get; set; }
        public string Status { get; set; }
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }
        public int? ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
