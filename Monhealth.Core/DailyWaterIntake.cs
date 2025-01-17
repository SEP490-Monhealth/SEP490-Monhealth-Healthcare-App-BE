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
    public class DailyWaterIntake : BaseEntity
    {
        public Guid DailyWaterIntakeId { get; set; }
        public Guid GoalId { get; set; }
        public Guid UserId { get; set; }
        public float TotalVolume { get; set; }

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }
    }
}
