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
        Task<UserSubscription>GetUserSubscriptionByIdAsync(Guid userSubscriptionId);
        Task<PaginatedResult<UserSubscription>> GetPagedUserSubscriptionAsync(int page, int limit, string? name , UserSubscriptionStatus? Status);
    }
}