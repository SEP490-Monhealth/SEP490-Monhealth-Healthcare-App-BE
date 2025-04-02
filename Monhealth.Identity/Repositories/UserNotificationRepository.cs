using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserNotificationRepository : GenericRepository<UserNotification, Guid>, IUserNotificationRepository
    {
        public UserNotificationRepository(MonhealthDbcontext context) : base(context)
        {
        }
    }
}
