using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class WalletRepository : GenericRepository<Wallet, Guid>, IWalletRepository
    {
        public WalletRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<Wallet> GetWalletByConsultantId(Guid consultantId)
        {
            return await _context.Wallets.FirstOrDefaultAsync(c => c.ConsultantId == consultantId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
