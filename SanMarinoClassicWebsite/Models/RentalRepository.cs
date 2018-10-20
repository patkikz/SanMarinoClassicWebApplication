using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class RentalRepository : IRentalRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ReservedItem _reservedItem;


        public RentalRepository(AppDbContext appDbContext, ReservedItem reservedItem)
        {
            _appDbContext = appDbContext;
            _reservedItem = reservedItem;
        }

        public void CreateRental(Rental rental)
        {
            rental.RentalPlaced = DateTime.Now;

            _appDbContext.Rentals.Add(rental);

            var reservation = _reservedItem.Reservations;

            foreach (var reservedItem in reservation)
            {
                var rentalDetail = new RentalDetail()
                {
                    Quantity = reservedItem.Quantity,
                    EquipmentId = reservedItem.Equipment.EquipmentId,
                    RentalId = rental.RentalId,
                    Price = reservedItem.Equipment.Price
                };

                _appDbContext.RentalDetails.Add(rentalDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}

