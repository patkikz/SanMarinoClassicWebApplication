using SanMarinoClassicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.ViewModels
{
    public class EquipmentListViewModel
    {
        public IEnumerable<Equipment> Equipments { get; set; }

        public string CurrentType { get; set; }
    }
}
