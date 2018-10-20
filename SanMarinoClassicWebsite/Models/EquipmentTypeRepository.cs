using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class EquipmentTypeRepository : IEquipmentTypeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EquipmentTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<EquipmentType> EquipmentTypes => _appDbContext.EquipmentTypes;
    }
}
