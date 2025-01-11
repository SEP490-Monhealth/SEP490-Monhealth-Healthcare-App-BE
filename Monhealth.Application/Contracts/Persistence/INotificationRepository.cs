using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface INotificationRepository : IGenericRepository<Notification, Guid>
    {
        Task<int> SaveChangeAsync();
    }
}