using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserNotificationRepository : IGenericRepository<UserNotification, Guid>
    {
    }
}
