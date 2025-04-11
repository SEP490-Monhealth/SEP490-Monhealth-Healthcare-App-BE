using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserSubscriptionRepository : IGenericRepository<UserSubscription, Guid>
    {
        Task<List<Subscription>> GetUserSubscription(Guid user);
        Task<int> SaveChangeAsync();
        Task<UserSubscription> GetByUserIdAsync(Guid userId);
        Task<List<UserSubscription>> GetUserSubcriptionByUserIdAsync(Guid userId);
        Task<UserSubscription> GetUserSubscriptionByIdAsync(Guid userSubscriptionId);
        Task<UserSubscription> GetUserSubScriptionByUserIdAndSubscriptionId(Guid subscriptionId, Guid userId);
        Task<UserSubscription> GetUserSubscriptionActiveOfUser(Guid userId);
        Task<PaginatedResult<UserSubscription>> GetPagedUserSubscriptionAsync(int page, int limit, string? name, string? search, UserSubscriptionStatus? Status);
        Task<List<UserSubscription>>GetUserSubscriptionsByUserIdAsync(Guid userId);
    }
}