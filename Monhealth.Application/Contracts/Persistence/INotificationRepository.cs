using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface INotificationRepository : IGenericRepository<Notification, Guid>
    {
        Task<PaginatedResult<Notification>> GetAllNotificationsAsync(int page, int limit, string? search);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
