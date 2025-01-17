using MediatR;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminderStatus
{
    public class UpdateReminderStatusCommand : IRequest<bool>
    {
        public Guid WaterReminderId { get; set; }
    }
}