using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Core
{
    public class WaterReminder : TimeEntity
    {
        [Key]
        public Guid WaterReminderId { get; set; }
        public Guid? UserId { get; set; }
        public string WaterReminderName { get; set; } = string.Empty;
        public string Time { get; set; }
        public float Volume { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsDrunk { get; set; }
        public bool Status { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
    }
}