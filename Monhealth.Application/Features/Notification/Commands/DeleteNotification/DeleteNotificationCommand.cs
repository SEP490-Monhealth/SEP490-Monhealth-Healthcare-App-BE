using MediatR;

namespace Monhealth.Application.Features.Notification.Commands.DeleteNotification
{
    public class DeleteNotificationCommand : IRequest<bool>
    {
        public Guid NotificationId { get; set; }
    }
}
