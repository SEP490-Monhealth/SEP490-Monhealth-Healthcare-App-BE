using MediatR;

namespace Monhealth.Application.Features.Notification.Commands.UpdateNotification
{
    public class UpdateNotificationCommand : IRequest<bool>
    {
        public Guid NotificationId { get; set; }
        public UpdateNotificationDTO UpdateNotificationDTO { get; set; }
        public UpdateNotificationCommand(Guid notificationId, UpdateNotificationDTO updateNotificationDTO)
        {
            NotificationId = notificationId;
            UpdateNotificationDTO = updateNotificationDTO;
        }
    }
}
