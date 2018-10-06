using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public DateTime DatePayment { get; set; }

        public int ReservationId { get; set; }

        public decimal Amount { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
