using MediatR;

namespace Monhealth.Application.Features.Reminders.Commands.DeleteReminder
{
    public class DeleteReminderCommand : IRequest<bool>
    {
        public Guid RemindId { get; set; }
    }
}