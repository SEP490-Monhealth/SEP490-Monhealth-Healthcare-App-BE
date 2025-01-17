using MediatR;

namespace Monhealth.Application.Features.WaterReminders.Commands.ChangeStatusIsDrunk
{
    public class ChangeStatusIsDrunkCommand : IRequest<bool>
    {
        public Guid WaterReminderId { get; set; }
    }
}