using MediatR;

namespace Monhealth.Application.Features.Reminder.Commands.CreateReminder
{
    public class CreateReminderCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public float Volume { get; set; }
        public string Time { get; set; } = string.Empty;
    }
}