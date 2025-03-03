using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class SubscriptionRepository : GenericRepository<Subscription, Guid>, ISubscriptionRepository
    {
        public SubscriptionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeAsync()
        {
             return await _context.SaveChangesAsync();
        }
    }
}