using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Repositories;

namespace Monhealth.Application
{
    public class WithDrawalRepository : GenericRepository<WithDrawalRequest, Guid>, IWithDrawalRepository
    {
        public WithDrawalRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeASync()
        {
         return await _context.SaveChangesAsync();
        }
    }
}