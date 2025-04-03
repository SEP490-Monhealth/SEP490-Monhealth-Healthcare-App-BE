using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserNotificationRepository : GenericRepository<UserNotification, Guid>, IUserNotificationRepository
    {
        public UserNotificationRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<UserNotification>> GetAllUserNotifications(int page, int limit, string? search)
        {
            IQueryable<UserNotification> query = _context.UserNotifications.AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                //query = query.Where(s => EF.Functions.Collate(s.Title, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower().Trim()) ||
                query = query.Where(s => s.UserNotificationId.ToString().Contains(search.ToLower().Trim()) ||
                                         s.UserId.ToString().Contains(search.ToLower().Trim()) ||
                                         s.NotificationId.ToString().ToLower().Contains(search.ToLower().Trim()));
            }
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<UserNotification>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<UserNotification>> GetUserNotificationByNotificationId(Guid notificationId)
        {
            return await _context.UserNotifications.Where(n => n.NotificationId == notificationId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
