using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Dtos.Reservation
{
    public class GetReservationDto
    {
        public int Id { get; set; }
        public DateTime ReservationTime { get; set; }
        public string Status { get; set; }
        public int? DoctorId { get; set; }
        public int? PatientId { get; set; }
        public int? ClinicId { get; set; }

    }
}
