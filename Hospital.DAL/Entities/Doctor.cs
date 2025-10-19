using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Doctor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Specialty { get; set; }

        public string PhoneNumber { get; set; }

        public int? ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
    }
}
