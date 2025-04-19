using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface INotificationRepository : IGenericRepository<Domain.Notification, Guid>
    {
        Task<PaginatedResult<Domain.Notification>> GetAllNotificationsAsync(int page, int limit, string? search);
        Task<PaginatedResult<Domain.Notification>> GetNotificationByUserId(int page, int limit, Guid userId);
        Task<PaginatedResult<Domain.Notification>> GetNotificationByConsultantId(int page, int limit, Guid? consultantId);
        Task<Domain.Notification> GetNotificationByNotificationId(Guid notificationId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
