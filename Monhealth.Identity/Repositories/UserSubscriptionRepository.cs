using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserSubscriptionRepository : GenericRepository<UserSubscription, Guid>, IUserSubscriptionRepository
    {
        public UserSubscriptionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<UserSubscription> GetByUserIdAsync(Guid userId)
        {
            return await _context.UserSubscriptions.FirstOrDefaultAsync(us => us.UserId == userId);
        }

        public async Task<PaginatedResult<UserSubscription>> GetPagedUserSubscriptionAsync(int page, int limit)
        {
            var query = _context.UserSubscriptions.
            Include(us => us.Subscription).
            Include(us => us.User).AsQueryable();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            var totalItems = await query.CountAsync();
            return new PaginatedResult<UserSubscription>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };

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