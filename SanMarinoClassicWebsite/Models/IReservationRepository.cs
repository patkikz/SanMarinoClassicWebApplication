﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public interface IReservationRepository
    {
        void CreateReservation(Reservation reservation);
    }
}
