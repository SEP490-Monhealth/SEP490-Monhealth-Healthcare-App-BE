using MediatR;

namespace Monhealth.Application.Features.Notification.Commands.IsReadNotificaiton
{
    public class IsReadNotificaitonCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public Guid NotificationId { get; set; }
        public IsReadNotificaitonCommand(Guid userId, Guid notificationId)
        {
            UserId = userId;
            NotificationId = notificationId;
        }
    }
}
