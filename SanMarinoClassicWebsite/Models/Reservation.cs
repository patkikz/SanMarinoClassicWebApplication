using Microsoft.AspNetCore.Mvc.ModelBinding;
using SanMarinoClassicWebsite.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public Equipment Equipment { get; set; }

        public int Quantity { get; set; }

        public string ReservedItemId { get; set; }
    }
}
