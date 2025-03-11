using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction, Guid>, ITransactionRepository
    {
        public TransactionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
