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

        public async Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit, TransactionType? type,
            string? search, StatusTransaction? status)
        {
            IQueryable<Transaction> query = _context.Transactions.Include(c => c.Wallet).ThenInclude(c => c.Consultant).ThenInclude(u => u.AppUser).AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                search = search.Trim().ToLower();
                query = query.Where(t =>
                    t.TransactionId.ToString().Contains(search.ToLower().Trim()) ||
                    t.WalletId.ToString().Contains(search.ToLower().Trim()) ||
                    t.BookingId.ToString().Contains(search.ToLower().Trim()) ||
                    EF.Functions.Collate(t.Wallet.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()));
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

        public async Task<List<Transaction>> GetTransactionByConsultantId(Guid consultantId, DateTime date)
        {
            int dayOfweek = (int)date.DayOfWeek;
            dayOfweek = dayOfweek == 0 ? 7 : dayOfweek;

            var monday = date.Date.AddDays(-dayOfweek + 1);
            var sunday = monday.AddDays(6).AddDays(1);
            return await _context.Transactions.Include(w => w.Wallet).ThenInclude(c => c.Consultant)
                .Where(c => c.Wallet.Consultant.ConsultantId == consultantId && c.CreatedAt >= monday && c.CreatedAt < sunday)
                .ToListAsync();
        }

        public async Task<Transaction> GetTransactionById(Guid transactionId)
        {
            return await _context.Transactions
                .Include(w => w.Wallet).ThenInclude(c => c.Consultant)
                .ThenInclude(u => u.AppUser)
                .FirstOrDefaultAsync(c => c.TransactionId == transactionId);
        }

        public async Task<Transaction> GetTransactionByOrderCode(long orderCode)
        {
            return await _context.Transactions
                .FirstOrDefaultAsync(t => t.OrderCode == orderCode);
        }

        public async Task<PaginatedResult<Transaction>> GetTransactionByWalletId(int page, int limit, Guid walletId, StatusTransaction? status)
        {
            var query = _context.Transactions.
            Include(w => w.Wallet).ThenInclude(c => c.Consultant)
            .ThenInclude(u => u.AppUser).Where(c => c.WalletId == walletId).AsQueryable();
            int totalItems = await query.CountAsync();
            if (status.HasValue)
            {
                query = query.Where(w => w.Status == status.Value);
            }
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

        public async Task<List<Transaction>> GetTransactionsByConsultantAndDateRange(Guid consultantId, DateTime from, DateTime to)
        {
            return await _context.Transactions.Include(w => w.Wallet).ThenInclude(c => c.Consultant)
            .Where(b => b.Wallet.Consultant.ConsultantId == consultantId && b.CreatedAt >= from && b.CreatedAt < to).ToListAsync();
        }

        public async Task<Transaction> GetTransactionWhenUpdated(TransactionType transactionType, float amount, StatusTransaction status)
        {
            return await _context.Transactions
                .FirstOrDefaultAsync(t => t.TransactionType == transactionType &&
                t.Amount == amount &&
                t.Status == status);

        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
