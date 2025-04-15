using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System.Linq.Dynamic.Core;

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
                .Include(us => us.Subscription)
                .Where(us => us.UserId == userId && us.Subscription != null && us.Status == UserSubscriptionStatus.Active)
                .FirstOrDefaultAsync();
        }
        public async Task<List<UserSubscription>> GetUserSubcriptionByUserIdAsync(Guid userId)
        {
            return await _context.UserSubscriptions
                .Include(s => s.Subscription)
                .Where(us => us.UserId == userId).ToListAsync();
        }

        public async Task<PaginatedResult<UserSubscription>> GetPagedUserSubscriptionAsync(int page, int limit, string? name, string? search,
            string? sort, string? order, UserSubscriptionStatus? Status)
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
            // sap xep
            if (!string.IsNullOrEmpty(sort))
            {
                string sorting = $"{sort} {(order?.ToLower() == "desc" ? "descending" : "ascending")}";
                query = query.OrderBy(sorting);
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

        public Task<List<UserSubscription>> GetTotalUserSubscriptionBySixMonth()
        {
            return _context.UserSubscriptions
                .Where(us => us.CreatedAt >= DateTime.UtcNow.AddMonths(-6))
                .ToListAsync();
        }

        public async Task<int> GetTotalSubscriptionUsersAsync(DateTime cutoff, CancellationToken cancellationToken)
        {
            // Lấy RoleId của "Subscription Member"
            var subscriptionRoleId = await _context.Roles
                .Where(r => r.Name == "Subscription Member")
                .Select(r => r.Id)
                .FirstOrDefaultAsync(cancellationToken);
            return await _context.Users
                         .Where(u => u.CreatedAt.HasValue &&
                                     u.CreatedAt.Value < cutoff &&
                                     u.Status &&
                                     _context.UserRoles.Any(ur => ur.UserId == u.Id && ur.RoleId == subscriptionRoleId))
                         .CountAsync(cancellationToken);
        }

        public async Task<int> GetNewSubscriptionUsersAsync(DateTime start, DateTime end, CancellationToken cancellationToken)
        {
            // Lấy RoleId của "Subscription Member"
            var subscriptionRoleId = await _context.Roles
                .Where(r => r.Name == "Subscription Member")
                .Select(r => r.Id)
                .FirstOrDefaultAsync(cancellationToken);
            return await _context.Users
           .Where(u => u.CreatedAt.HasValue &&
            u.CreatedAt.Value >= start &&
            u.CreatedAt.Value < end &&
            u.Status &&
            _context.UserRoles.Any(ur => ur.UserId == u.Id && ur.RoleId == subscriptionRoleId))
           .CountAsync(cancellationToken);
        }

        public async Task<List<UserSubscription>> GetAllUserSubscriptionAsync()
        {
            return await _context.UserSubscriptions.Include(c => c.Subscription).ToListAsync();

        }

         public async Task<int> GetUserSubscriptionCountByNamesAsync(
            Guid[] subscriptionIds)
        {
            return await _context.UserSubscriptions
                .Where(us => subscriptionIds.Contains(us.Subscription.SubscriptionId))
                .CountAsync();
        }

        public async Task<int> GetUserSubscriptionCountByNamesAsync(
            Guid[] subscriptionIds, DateTime createdAt)
        {
            // Giả sử createdAt được dùng để lọc theo tháng (từ đầu tháng hiện tại đến đầu tháng sau)
            var startDate = new DateTime(createdAt.Year, createdAt.Month, 1);
            var endDate = startDate.AddMonths(1);

            return await _context.UserSubscriptions
                .Where(us => subscriptionIds.Contains(us.Subscription.SubscriptionId) &&
                             us.CreatedAt >= startDate && us.CreatedAt < endDate)
                .CountAsync();
        }
    }
}