using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction, Guid>, ITransactionRepository
    {
        public TransactionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit, TransactionType? type, string? search, StatusTransaction? status
        )
        {
            IQueryable<Transaction> query = _context.Transactions.Include(t => t.Wallet)
            .ThenInclude(u => u.Consultant).ThenInclude(u => u.AppUser)
            .AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(t =>
                    t.TransactionId.ToString().Contains(search) ||
                    t.Wallet.Consultant.AppUser.FullName.ToLower().Contains(search)
                );
            }
            if (type.HasValue)
            {
                query = query.Where(t => t.TransactionType == type);
            }
            if (status.HasValue)
            {
                query = query.Where(t => t.Status == status);
            }
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

        public async Task<Transaction> GetTransactionById(Guid transactionId)
        {
            return await _context.Transactions.Include(w => w.Wallet).ThenInclude(c => c.Consultant).FirstOrDefaultAsync(c => c.TransactionId == transactionId);
        }

        public async Task<List<Transaction>> GetTransactionByWalletId(Guid walletId)
        {
            return await _context.Transactions.Include(w => w.Wallet).ThenInclude(c => c.Consultant).Where(c => c.WalletId == walletId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
