using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class NotificationRepository : GenericRepository<Notification, Guid>, INotificationRepository
    {
        public NotificationRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Notification>> GetAllNotificationsAsync(int page, int limit, string? search)
        {
            IQueryable<Notification> query = _context.Notifications.Include(un => un.UserNotifications).AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.Title, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower().Trim()) ||
                    s.NotificationId.ToString().ToLower().Contains(search.ToLower().Trim()));
            }
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Notification>
            {
                Items = await query.OrderByDescending(n => n.CreatedAt).ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<PaginatedResult<Notification>> GetNotificationByConsultantId(int page, int limit, Guid? consultantId)
        {
            var query = _context.UserNotifications
                .Where(un => un.UserId == consultantId)
                .Include(un => un.Notification)
                .Include(un => un.AppUser);

            int totalItems = await query.CountAsync();

            var notifications = await query
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return new PaginatedResult<Notification>
            {
                Items = notifications.OrderByDescending(n => n.CreatedAt).Select(un => un.Notification).ToList(),
                TotalCount = totalItems,
            };
        }

        public async Task<Notification> GetNotificationByNotificationId(Guid notificationId)
        {
            return await _context.Notifications
                .Include(un => un.UserNotifications)
                .FirstOrDefaultAsync(n => n.NotificationId == notificationId);
        }

        public async Task<PaginatedResult<Notification>> GetNotificationByUserId(int page, int limit, Guid userId)
        {
            //var notificationsQuery = _context.UserNotifications
            //.Where(un => un.UserId == userId)
            //.Include(un => un.Notification).AsQueryable();

            //int totalItems = await notificationsQuery.CountAsync();

            //if (page > 0 && limit > 0)
            //{
            //    notificationsQuery = notificationsQuery.Skip((page - 1) * limit).Take(limit);
            //}

            //return new PaginatedResult<Notification>
            //{
            //    Items = await notificationsQuery
            //    .OrderByDescending(un => un.CreatedAt)
            //    .Select(un => un.Notification).ToListAsync(),
            //    TotalCount = totalItems
            //};
            
            var query = _context.UserNotifications
                .Where(un => un.UserId == userId)
                .Include(un => un.Notification)
                .Include(un => un.AppUser);

            int totalItems = await query.CountAsync();

            var notifications = await query
                .Skip((page - 1) * limit)
                .Take(limit)
                .ToListAsync();

            return new PaginatedResult<Notification>
            {
                Items = notifications.OrderByDescending(n => n.CreatedAt).Select(un => un.Notification).ToList(),
                TotalCount = totalItems,
            };
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
