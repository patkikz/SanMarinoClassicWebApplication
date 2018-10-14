using SanMarinoClassicWebsite.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
