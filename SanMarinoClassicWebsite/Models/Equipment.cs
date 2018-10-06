using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }

        public int EquipmentTypeId { get; set; }

        public virtual EquipmentType EquipmentType { get; set; }
    }
}
