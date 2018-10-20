using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanMarinoClassicWebsite.Models;
using SanMarinoClassicWebsite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SanMarinoClassicWebsite.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IEquipmentTypeRepository _equipmentTypeRepository;


        public EquipmentController(IEquipmentRepository equipmentRepository, IEquipmentTypeRepository equipmentTypeRepository)
        {
            _equipmentRepository = equipmentRepository;
            _equipmentTypeRepository = equipmentTypeRepository;
        }

        public ViewResult List(string equipmentType)
        {
            //throw new Exception("Error");
            IEnumerable<Equipment> equipments;
            string currentType = string.Empty;

            if (string.IsNullOrEmpty(equipmentType))
            {
                equipments = _equipmentRepository.Equipments.OrderBy(e => e.EquipmentId);
                currentType = "All equipments";
            }
            else
            {
                equipments = _equipmentRepository.Equipments.Where(e => e.EquipmentType.Name == equipmentType)
                    .OrderBy(p => p.EquipmentId);
                currentType = _equipmentTypeRepository.EquipmentTypes.FirstOrDefault(et => et.Name == equipmentType).Name;
            }

            return View(new EquipmentListViewModel
            {
                Equipments = equipments,
                CurrentType = currentType
            });
        }

        public IActionResult Details(int id)
        {
            var equipment = _equipmentRepository.GetEquipmentById(id);
            if (equipment == null)
                return NotFound();

            return View(equipment);
        }
    }
}
