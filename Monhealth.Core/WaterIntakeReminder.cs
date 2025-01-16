using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Core;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class WaterIntakeReminder : BaseEntity
    {
        public Guid WaterIntakeReminderId { get; set; }
        public Guid WaterIntakeId { get; set; }
        public Guid WaterReminderId { get; set; }
        public bool Status { get; set; }

        [ForeignKey(nameof(WaterReminderId))]
        public WaterReminder WaterReminder { get; set; }
        [ForeignKey(nameof(WaterIntakeId))]
        public WaterIntake WaterIntake { get; set; }
    }
}
