using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderRequest
    {
        
        [JsonPropertyName("name")]
        public string ReminderName { get; set; } =string.Empty;
        public string Time { get; set; } = string.Empty;
        public float Volume { get; set; }
    }
}