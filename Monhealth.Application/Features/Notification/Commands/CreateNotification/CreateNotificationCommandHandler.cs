using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Notification.Commands.CreateNotification
{
    public class CreateNotificationCommandHandler(INotificationRepository notificationRepository, IMapper mapper) : IRequestHandler<CreateNotificationCommand, Unit>
    {
        public async Task<Unit> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
        {
            var today = DateTime.Now;
            var newNotification = mapper.Map<Domain.Notification>(request.CreateNotificationDTO);
            newNotification.NotificationId = Guid.NewGuid();

            var vietNameTimeNow = GetCurrentVietnamTime();
            newNotification.CreatedAt = vietNameTimeNow;
            newNotification.UpdatedAt = vietNameTimeNow;
            notificationRepository.Add(newNotification);
            await notificationRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
