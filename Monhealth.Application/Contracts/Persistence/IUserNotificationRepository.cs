using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserNotificationRepository : IGenericRepository<UserNotification, Guid>
    {
        Task<PaginatedResult<UserNotification>> GetAllUserNotifications(int page, int limit, Guid? userId, string? search);
        Task<List<UserNotification>> GetUserNotificationByUserId(Guid userId);
        Task<List<UserNotification>> GetUserNotificationByNotificationId(Guid notificationId);
        Task<UserNotification> IsReadNotification(Guid userId, Guid notificationId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
