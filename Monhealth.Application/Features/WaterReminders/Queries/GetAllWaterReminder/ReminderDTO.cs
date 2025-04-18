using Monhealth.Domain.Common;
using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class ReminderDTO : BaseEntity
    {
        public Guid WaterReminderId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("name")]
        public string WaterReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public float Volume { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsDrunk { get; set; }
        public bool Status { get; set; }
    }
}