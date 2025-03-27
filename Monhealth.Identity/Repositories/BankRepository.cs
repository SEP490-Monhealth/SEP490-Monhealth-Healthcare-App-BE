using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class BankRepository : GenericRepository<Bank, Guid>, IBankRepository
    {
        public BankRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<bool> CheckBankNameExisted(string? bankName)
        {
            return await _context.Banks.AnyAsync(n => n.BankName.ToLower() == bankName.ToLower().Trim());
        }

        public async Task<bool> CheckBankCodeExisted(string? bankCode)
        {
            return await _context.Banks.AnyAsync(n => n.BankCode.ToLower() == bankCode.ToLower().Trim());
        }

        public async Task<bool> CheckShortNameExisted(string? shortName)
        {
            return await _context.Banks.AnyAsync(n => n.ShortName.ToLower() == shortName.ToLower().Trim());
        }

        public async Task<PaginatedResult<Bank>> GetAllBanksAsync(int page, int limit, string? search, bool? status)
        {
            search = search?.ToLower().Trim();
            IQueryable<Bank> query = _context.Banks.AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => s.BankId.ToString().ToLower().Contains(search) || 
                    EF.Functions.Collate(s.BankName, "SQL_Latin1_General_CP1_CI_AI").Contains(search) ||
                    s.BankCode.ToLower().Contains(search) ||
                    s.ShortName.ToLower().Contains(search));
            }
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Bank>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
