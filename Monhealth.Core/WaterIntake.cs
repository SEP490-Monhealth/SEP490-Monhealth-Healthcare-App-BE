using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class WaterIntake : BaseEntity
    {
        public Guid WaterIntakeId { get; set; }
        public Guid DailyWaterIntakeId { get; set; }
        public Guid UserId { get; set; }

        [ForeignKey(nameof(DailyWaterIntakeId))]
        public DailyWaterIntake DailyWaterIntake { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<WaterIntakeReminder> WaterIntakeReminders { get; set; }
    }
}
