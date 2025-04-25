using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Notification.Commands.CreateNotification
{
    public class CreateNotificationCommandHandler(INotificationRepository notificationRepository, IMapper mapper) : IRequestHandler<CreateNotificationCommand, Unit>
    {
        public async Task<Unit> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
        {
            var today = DateTime.UtcNow;
            var newNotification = mapper.Map<Domain.Notification>(request.CreateNotificationDTO);
            newNotification.NotificationId = Guid.NewGuid();
            newNotification.CreatedAt = today;
            newNotification.UpdatedAt = today;
            notificationRepository.Add(newNotification);
            await notificationRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
