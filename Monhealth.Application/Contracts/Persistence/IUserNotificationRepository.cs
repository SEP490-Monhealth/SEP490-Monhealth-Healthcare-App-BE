using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserNotificationRepository : IGenericRepository<UserNotification, Guid>
    {
        Task<PaginatedResult<UserNotification>> GetAllUserNotifications(int page, int limit, string? search);
        Task<List<UserNotification>> GetUserNotificationByNotificationId(Guid notificationId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
