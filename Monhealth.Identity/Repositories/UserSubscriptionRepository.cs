using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserSubscriptionRepository : GenericRepository<UserSubscription, Guid>, IUserSubscriptionRepository
    {
        public UserSubscriptionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public Task<UserSubscription> GetByUserIdAsync(Guid userId)
        {
            return _context.UserSubscriptions.FirstOrDefaultAsync(us => us.UserId == userId);
        }

        public Task<List<Subscription>> GetUserSubscription(Guid user)
        {
            return _context.UserSubscriptions.Where(us => us.UserId == user)
            .Select(us => us.Subscription).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}