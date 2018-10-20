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

        public string EquipmentShortDescription { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public decimal Price { get; set; }

        public bool IsInStock { get; set; }

        public virtual EquipmentType EquipmentType { get; set; }
    }
}
