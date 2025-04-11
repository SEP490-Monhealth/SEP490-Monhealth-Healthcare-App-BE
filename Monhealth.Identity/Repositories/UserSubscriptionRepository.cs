using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
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
            return await _context.UserSubscriptions
                .Include(s => s.Subscription)
                .FirstOrDefaultAsync(us => us.UserId == userId);
        }
        public async Task<List<UserSubscription>> GetUserSubcriptionByUserIdAsync(Guid userId)
        {
            return await _context.UserSubscriptions
                .Include(s => s.Subscription)
                .Where(us => us.UserId == userId).ToListAsync();
        }

        public async Task<PaginatedResult<UserSubscription>> GetPagedUserSubscriptionAsync(int page, int limit, string? name, string? search, UserSubscriptionStatus? Status)
        {
            search = search?.ToLower().Trim();
            var query = _context.UserSubscriptions.
            Include(us => us.Subscription).
            Include(us => us.User).AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(s => s.UserSubscriptionId.ToString().ToLower().Contains(search) ||
                                         s.UserId.ToString().ToLower().Contains(search) ||
                                         s.SubscriptionId.ToString().ToLower().Contains(search) ||
                                         EF.Functions.Collate(s.Subscription.SubscriptionName, "SQL_Latin1_General_CP1_CI_AI").Contains(search) ||
                                         EF.Functions.Collate(s.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search) ||
                                         s.User.Email.ToLower().Contains(search) ||
                                         s.User.PhoneNumber.ToLower().Contains(search));
            }
            if (name is not null)
            {
                query = query.Where(us => us.Subscription.SubscriptionName == name);
            }
            if (Status.HasValue)
            {
                query = query.Where(us => us.Status == Status);
            }
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

        public Task<UserSubscription> GetUserSubscriptionActiveOfUser(Guid userId)
        {
            return _context.UserSubscriptions
                .Where(us => us.UserId == userId &&
                        us.Status == UserSubscriptionStatus.Active &&
                        us.RemainingBookings > 0
                ).OrderByDescending(us => us.CreatedAt)
                .FirstOrDefaultAsync();
        }

        public async Task<UserSubscription> GetUserSubscriptionByIdAsync(Guid userSubscriptionId)
        {
            return await _context.UserSubscriptions.
            Include(us => us.Subscription).
            Include(us => us.User)
            .FirstOrDefaultAsync(us => us.UserSubscriptionId == userSubscriptionId);
        }

        public async Task<UserSubscription> GetUserSubScriptionByUserIdAndSubscriptionId(Guid subscriptionId, Guid userId)
        {
            return await _context.UserSubscriptions.FirstOrDefaultAsync(us => us.UserId == userId && us.SubscriptionId == subscriptionId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public Task<List<UserSubscription>> GetUserSubscriptionsByUserIdAsync(Guid userId)
        {
            return _context.UserSubscriptions
                .Include(s => s.Subscription)
                .Where(us => us.UserId == userId).ToListAsync();
        }
    }
}