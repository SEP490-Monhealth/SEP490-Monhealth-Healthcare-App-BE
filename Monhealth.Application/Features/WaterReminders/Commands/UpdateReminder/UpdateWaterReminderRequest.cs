using System.Text.Json.Serialization;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderRequest
    {
        
        [JsonPropertyName("name")]
        public string WaterReminderName { get; set; } =string.Empty;
        public string Time { get; set; } = string.Empty;
        public int Volume { get; set; }
        public bool IsRecurring { get; set; }
    }
}