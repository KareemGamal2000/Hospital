using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Clinic
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public ICollection<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
    }
}
