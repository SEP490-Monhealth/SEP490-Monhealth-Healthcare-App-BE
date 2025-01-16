using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Queries.GetReminderByUser
{
    public class GetAllReminderByUserDTO
    {
        public Guid ReminderId { get; set; }
        [JsonPropertyName("name")]
        public string ReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public float Volume { get; set; }
        public bool Status { get; set; }
    }
}