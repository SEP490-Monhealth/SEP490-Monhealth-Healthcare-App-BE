using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderRequest
    {
        
        [JsonPropertyName("name")]
        public string ReminderName { get; set; } =string.Empty;
        public TimeSpan Time { get; set; }
        public int Volume { get; set; }
    }
}