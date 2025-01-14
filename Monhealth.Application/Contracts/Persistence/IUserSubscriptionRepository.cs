using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserSubscriptionRepository : IGenericRepository<UserSubscription, Guid>
    {
        Task<List<Subscription>> GetUserSubscription(Guid user);
    }
}