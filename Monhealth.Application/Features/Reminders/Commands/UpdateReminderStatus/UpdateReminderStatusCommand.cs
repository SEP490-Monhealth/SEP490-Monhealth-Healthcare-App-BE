using MediatR;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminderStatus
{
    public class UpdateReminderStatusCommand : IRequest<bool>
    {
        public Guid ReminderId { get; set; }
    }
}