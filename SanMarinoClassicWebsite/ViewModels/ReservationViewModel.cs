using SanMarinoClassicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.ViewModels
{
    public class ReservationViewModel
    {
        public ReservedItem ReservedItem { get; set; }
        public decimal ReservationTotal { get; set; }
    }
}
