using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanMarinoClassicWebsite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SanMarinoClassicWebsite.Controllers
{
    public class RentalController : Controller
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly ReservedItem _reservedItem;

        public RentalController(IRentalRepository rentalRepository, ReservedItem reservedItem)
        {
            _rentalRepository = rentalRepository;
            _reservedItem = reservedItem;
        }


        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Rental rental)
        {
            var items = _reservedItem.GetReservation();
            _reservedItem.Reservations = items;

            if (_reservedItem.Reservations.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some reservations first!");
            }

            if (ModelState.IsValid)
            {
                _rentalRepository.CreateRental(rental);
                _reservedItem.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(rental);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your reservation. You will soon utilize the items you reserved!";
            return View();
        }
    }
}

