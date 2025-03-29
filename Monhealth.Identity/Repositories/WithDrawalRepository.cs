using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Repositories;

namespace Monhealth.Application
{
    public class WithdrawalRepository : GenericRepository<WithdrawalRequest, Guid>, IWithdrawalRepository
    {
        public WithdrawalRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeASync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}