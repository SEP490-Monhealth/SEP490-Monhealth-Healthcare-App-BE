using MediatR;

namespace Monhealth.Application.Features.Notification.Commands.CreateNotification
{
    public class CreateNotificationCommand : IRequest<Unit>
    {
        public CreateNotificationDTO CreateNotificationDTO { get; set; }
        public CreateNotificationCommand(CreateNotificationDTO createNotificationDTO)
        {
            CreateNotificationDTO = createNotificationDTO;
        }
    }
}
