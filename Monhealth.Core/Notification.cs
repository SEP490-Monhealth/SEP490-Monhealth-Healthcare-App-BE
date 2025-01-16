using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Core
{
    public class Notification
    {
        [Key]
        public Guid NotificationId { get; set; }
        public Guid ReminderId { get; set; }
        public DateTime NotifyTime { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsSent { get; set; }
        [ForeignKey(nameof(ReminderId))]
        public WaterReminder Reminder { get; set; }
    }
}