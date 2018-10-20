using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> Equipments { get; }

        Equipment GetEquipmentById (int equipmentId);
    }
}
