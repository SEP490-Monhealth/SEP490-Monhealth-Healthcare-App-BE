using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserSubscriptionRepository : IGenericRepository<UserSubscription, Guid>
    {
        Task<List<Subscription>> GetUserSubscription(Guid user);
        Task<int> SaveChangeAsync();
        Task<UserSubscription> GetByUserIdAsync(Guid userId);
        Task<PaginatedResult<UserSubscription>> GetPagedUserSubscriptionAsync(int page, int limit);
    }
}