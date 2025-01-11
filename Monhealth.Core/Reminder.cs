using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Core
{
    public class Reminder : BaseEntity
    {
        [Key]
        public Guid ReminderId { get; set; }
        public Guid? UserId { get; set; }
        public Guid GoalId { get; set; }
        public float Volume { get; set; }
        public string ReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public bool Status { get; set; }
        public bool IsDefault { get; set; }
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}