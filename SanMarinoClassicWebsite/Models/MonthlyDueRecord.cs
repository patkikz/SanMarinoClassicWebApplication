using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanMarinoClassicWebsite.Models
{
    public class MonthlyDueRecord
    {
        public int MonthlyDueRecordId { get; set; }

        public int MonthlyDueId { get; set; }

        public virtual MonthlyDue MonthlyDue { get; set; }

        public DateTime DateDue { get; set; }

        public DateTime DatePaid { get; set; }

    }
}
