using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanMarinoClassicWebsite.Models;
using SanMarinoClassicWebsite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Controllers
{
    [Authorize]
    public class ReservedItemController: Controller
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly ReservedItem _reservedItem;

        public ReservedItemController(IEquipmentRepository equipmentRepository, ReservedItem reservedItem)
        {
            _equipmentRepository = equipmentRepository;
            _reservedItem = reservedItem;
        }

        public ViewResult Index()
        {
            var items = _reservedItem.GetReservation();
            _reservedItem.Reservations = items;

            var reservedItemViewModel = new ReservedItemViewModel
            {
                ReservedItem = _reservedItem,
                ReservationTotal = _reservedItem.GetReservationTotal()
            };

            return View(reservedItemViewModel);
        }
        public RedirectToActionResult AddToReservation(int equipmentId)
        {
            var selectedEquipment = _equipmentRepository.Equipments.FirstOrDefault(e => e.EquipmentId == equipmentId);


            if (selectedEquipment != null)
            {
                _reservedItem.AddToReservedItem(selectedEquipment, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int equipmentId)
        {
            var selectedEquipment = _equipmentRepository.Equipments.FirstOrDefault(e => e.EquipmentId == equipmentId);

            if (selectedEquipment != null)
            {
                _reservedItem.RemovedFromReservedItem(selectedEquipment);
            }
            return RedirectToAction("Index");
        }
    }
}
