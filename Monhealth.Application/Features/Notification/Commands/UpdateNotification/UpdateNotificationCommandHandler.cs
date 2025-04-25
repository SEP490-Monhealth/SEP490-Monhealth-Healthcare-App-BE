using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Notification.Commands.UpdateNotification
{
    public class UpdateNotificationCommandHandler(INotificationRepository notificationRepository, IMapper mapper) : IRequestHandler<UpdateNotificationCommand, bool>
    {
        public async Task<bool> Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
        {
            var notification = await notificationRepository.GetByIdAsync(request.NotificationId);
            if (notification == null)
            {
                return false;
            }
            var updateNotification = mapper.Map(request.UpdateNotificationDTO, notification);
            updateNotification.UpdatedAt = GetCurrentVietnamTime();
            notificationRepository.Update(updateNotification);
            await notificationRepository.SaveChangeAsync(cancellationToken);
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
