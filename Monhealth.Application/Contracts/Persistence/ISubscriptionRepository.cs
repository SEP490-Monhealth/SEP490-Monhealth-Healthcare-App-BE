using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ISubscriptionRepository : IGenericRepository<Subscription, Guid>
    {
          Task<int>SaveChangeAsync();
    }
}