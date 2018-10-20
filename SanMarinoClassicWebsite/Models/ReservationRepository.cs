using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public ReservationRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateReservation(Reservation reservation)
        {
            //reservation.DateReserved = DateTime.Now;

            _appDbContext.Reservations.Add(reservation);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var reservationDetail = new ReservationDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    EquipmentId = shoppingCartItem.Equipment.EquipmentId,
                    ReservationId = reservation.ReservationId,
                    Price = shoppingCartItem.Equipment.Price,
               
                };

                _appDbContext.ReservationDetails.Add(reservationDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
