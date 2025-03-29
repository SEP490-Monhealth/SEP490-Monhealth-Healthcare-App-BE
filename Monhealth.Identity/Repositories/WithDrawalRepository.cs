using Microsoft.EntityFrameworkCore;
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

        public async Task<List<WithdrawalRequest>> GetAllWithdrawalRequestAsync()
        {
            return await _context.WithdrawalRequests.Include(wd => wd.Consultant)
            .ThenInclude(u => u.AppUser)
            .Include(b => b.Consultant).ThenInclude(c => c.ConsultantBanks)
            .ThenInclude(b => b.Bank)
            .Include(c => c.Consultant).ThenInclude(cs => cs.Wallet)
            .ThenInclude(cs => cs.Transactions).ToListAsync();
        }

        public async Task<WithdrawalRequest> GetWithdrawalRequest(Guid withDrawalId)
        {
            return await _context.WithdrawalRequests.Include(wd => wd.Consultant)
            .ThenInclude(u => u.AppUser)
            .Include(b => b.Consultant).ThenInclude(c => c.ConsultantBanks)
            .ThenInclude(b => b.Bank)
            .Include(c => c.Consultant).ThenInclude(cs => cs.Wallet)
            .ThenInclude(cs => cs.Transactions).FirstOrDefaultAsync(wd => wd.WithdrawalRequestId == withDrawalId);    
        }

        public async Task<int> SaveChangeASync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}