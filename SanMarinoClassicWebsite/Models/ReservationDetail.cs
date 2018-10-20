using SanMarinoClassicWebsite.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class ReservationDetail
    {
        public int ReservationDetailId { get; set; }

        public int ReservationId { get; set; }

        public int EquipmentId { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Reservation Reservation { get; set; }

     
        public int StatusId { get; set; }

        
        public virtual Status Status { get; set; }
    }
}
