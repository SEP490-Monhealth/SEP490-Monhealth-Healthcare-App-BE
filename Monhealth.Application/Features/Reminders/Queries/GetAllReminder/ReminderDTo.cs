using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Queries.GetAllReminder
{
    public class ReminderDTo
    {
        public Guid ReminderId { get; set; }
        public Guid UserId { get; set; }
        [JsonPropertyName("name")]
        public string ReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public float Volume { get; set; }
        public bool IsDefault { get; set; }
        public bool Status { get; set; }
    }
}