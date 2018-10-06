using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public int EquipmentId { get; set; }

        public int StatusId { get; set; }

        public DateTime DateReserved { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Status Status { get; set; }
    }
}
