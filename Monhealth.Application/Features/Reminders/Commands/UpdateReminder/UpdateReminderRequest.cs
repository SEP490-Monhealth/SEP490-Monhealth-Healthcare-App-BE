using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderRequest
    {
        public float Volume { get; set; }
        public string Time { get; set; } = string.Empty;
        [JsonPropertyName("Name")]
        public string ReminderName { get; set; } =string.Empty;
    }
}