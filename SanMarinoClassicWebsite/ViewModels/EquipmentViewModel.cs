using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.ViewModels
{
    public class EquipmentViewModel
    {
        public int EquipmentId { get; set; }

        public string EquipmentShortDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageThumbnailUrl { get; set; }
    }
}
