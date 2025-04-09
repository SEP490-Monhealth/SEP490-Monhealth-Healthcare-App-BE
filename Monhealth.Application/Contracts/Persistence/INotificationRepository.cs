using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface INotificationRepository : IGenericRepository<Domain.Notification, Guid>
    {
        Task<PaginatedResult<Domain.Notification>> GetAllNotificationsAsync(int page, int limit, string? search);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
