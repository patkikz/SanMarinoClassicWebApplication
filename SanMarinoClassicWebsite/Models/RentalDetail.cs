using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class RentalDetail
    {
        public int RentalDetailId { get; set; }

        public int RentalId { get; set; }

        public int EquipmentId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public virtual Equipment Equipment { get; set; }

        public virtual Rental Rental { get; set; }
    }
}
