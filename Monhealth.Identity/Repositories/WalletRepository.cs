using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class WalletRepository : GenericRepository<Wallet, Guid>, IWalletRepository
    {
        public WalletRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Wallet>> GetAllWalletAsync(int page, int limit, bool? status)
        {
            IQueryable<Wallet> query = _context.Wallets.AsNoTracking().AsQueryable();
            //if (!string.IsNullOrEmpty(search))
            //{
            //    query = query.Where(b => EF.Functions.Collate(b.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
            //                       b.Consultant.AppUser.FullName.ToLower().Contains(search.ToLower()));
            //}
            if (status.HasValue)
            {
                query = query.Where(t => t.Status == status.Value);
            }
            query = query.OrderBy(w => w.CreatedAt);
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Wallet>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
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
