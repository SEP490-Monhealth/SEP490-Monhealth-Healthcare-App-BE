using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction, Guid>, ITransactionRepository
    {
        public TransactionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit)
        {
            IQueryable<Transaction> query = _context.Transactions.AsQueryable();
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Transaction>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<Transaction> GetTransactionByWalletId(Guid walletId)
        {
            return await _context.Transactions.FirstOrDefaultAsync(c => c.WalletId == walletId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
