using System.Text.Json.Serialization;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderDetail
{
    public class ReminderDetailDTO : TimeEntity
    {
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