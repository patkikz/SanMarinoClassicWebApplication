using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class EquipmentType
    {
        public int EquipmentTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Equipment> Equipments { get; set; }
    }
}
