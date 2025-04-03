using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Notification.Commands.DeleteNotification
{
    public class DeleteNotificationCommandHandler(INotificationRepository notificationRepository) : IRequestHandler<DeleteNotificationCommand, bool>
    {
        public async Task<bool> Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
        {
            var notification = await notificationRepository.GetByIdAsync(request.NotificationId);
            if (notification == null)
            {
                return false;
            }
            notificationRepository.Remove(notification);
            await notificationRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
