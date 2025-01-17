using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Reminder.Commands.CreateReminder
{
    public class CreateWaterReminderCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("name")]
        public string WaterReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public int Volume { get; set; }
        public bool IsRecurring { get; set; }
    }
}