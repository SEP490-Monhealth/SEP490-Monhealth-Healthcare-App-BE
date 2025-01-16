using System.Text.Json.Serialization;
using MediatR;

namespace Monhealth.Application.Features.Reminder.Commands.CreateReminder
{
    public class CreateReminderCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        [JsonPropertyName("name")]
        public string ReminderName { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public int Volume { get; set; }
    }
}