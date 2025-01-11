using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class NotificationRepository : GenericRepository<Notification, Guid>, INotificationRepository
    {
        public NotificationRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}