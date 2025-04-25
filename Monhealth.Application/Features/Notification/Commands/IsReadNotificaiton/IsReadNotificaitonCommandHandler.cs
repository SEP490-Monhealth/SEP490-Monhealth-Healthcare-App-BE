using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Notification.Commands.IsReadNotificaiton
{
    public class IsReadNotificaitonCommandHandler(IUserNotificationRepository userNotificationRepository) : IRequestHandler<IsReadNotificaitonCommand, bool>
    {
        public async Task<bool> Handle(IsReadNotificaitonCommand request, CancellationToken cancellationToken)
        {
            // Tìm UserNotification theo UserId và NotificationId
            var userNotification = await userNotificationRepository.IsReadNotification(request.UserId, request.NotificationId);

            if (userNotification == null)
                throw new NotFoundException("Không tìm thấy thông báo người dùng.");

            if (!userNotification.IsRead)
            {
                userNotification.IsRead = true;
                userNotification.UpdatedAt = GetCurrentVietnamTime();
                userNotificationRepository.Update(userNotification);
            }
            else
            {
                throw new NotFoundException("Thông báo này đã đọc.");
            }
            await userNotificationRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
