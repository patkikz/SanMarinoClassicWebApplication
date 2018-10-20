using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly AppDbContext _appDbContext;

       public EquipmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Equipment> Equipments
        {
            get
            {
                return _appDbContext.Equipments.Include(et => et.EquipmentType);
            }
        }

        public IEnumerable<Equipment> Equipment => throw new NotImplementedException();

        public Equipment GetEquipmentById(int equipmentId)
        {
            return _appDbContext.Equipments.FirstOrDefault(e => e.EquipmentId == equipmentId);
        }
    }
}
