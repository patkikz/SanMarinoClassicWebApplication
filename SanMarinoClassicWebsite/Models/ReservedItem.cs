using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SanMarinoClassicWebsite.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class ReservedItem
    {
        private readonly AppDbContext _appDbContext;
  
        
        private ReservedItem(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ReservedItemId { get; set; }

        public List<Reservation> Reservations { get; set; }

        public static ReservedItem GetReserved(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string reservedItemId = session.GetString("ItemId") ?? Guid.NewGuid().ToString();

            session.SetString("ItemId", reservedItemId);

            return new ReservedItem(context) { ReservedItemId = reservedItemId };


        }

        public void AddToReservedItem(Equipment equipment, int quantity)
        {
           
            var reservation =
                    _appDbContext.Reservations.SingleOrDefault(
                        s => s.Equipment.EquipmentId == equipment.EquipmentId && s.ReservedItemId == ReservedItemId);

            if (reservation == null)
            {
                reservation = new Reservation
                {
                    ReservedItemId = ReservedItemId,
                    Equipment = equipment,
                    Quantity = 1,
       
                };

                _appDbContext.Reservations.Add(reservation);
            }
            else
            {
                reservation.Quantity++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemovedFromReservedItem(Equipment equipment)
        {
            var reservation =
                    _appDbContext.Reservations.SingleOrDefault(
                        s => s.Equipment.EquipmentId == equipment.EquipmentId && s.ReservedItemId == ReservedItemId);

            var localQuantity = 0;

            if (reservation != null)
            {
                if (reservation.Quantity > 1)
                {
                    reservation.Quantity--;
                    localQuantity = reservation.Quantity;
                }
                else
                {
                    _appDbContext.Reservations.Remove(reservation);
                }
            }

            _appDbContext.SaveChanges();

            return localQuantity;
        }

        public List<Reservation> GetReservation()
        {
            return Reservations ??
                   (Reservations =
                       _appDbContext.Reservations.Where(c => c.ReservedItemId == ReservedItemId)
                           .Include(s => s.Equipment)
                           .ToList());
        }

        public void ClearCart()
        {
            var reservedItems = _appDbContext
                .Reservations
                .Where(item => item.ReservedItemId == ReservedItemId);

            _appDbContext.Reservations.RemoveRange(reservedItems);

            _appDbContext.SaveChanges();
        }



        public decimal GetReservationTotal()
        {
            var total = _appDbContext.Reservations.Where(c => c.ReservedItemId == ReservedItemId)
                .Select(c => c.Equipment.Price * c.Quantity).Sum();
            return total;
        }
    }
}
