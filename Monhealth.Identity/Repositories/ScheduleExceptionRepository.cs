using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ScheduleExceptionRepository : GenericRepository<ScheduleException, Guid>, IScheduleExceptionRepository
    {
        public ScheduleExceptionRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
