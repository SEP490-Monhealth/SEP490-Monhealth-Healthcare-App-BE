using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
namespace Monhealth.Identity.Repositories
{
    public class ConsultantBankRepository : GenericRepository<ConsultantBank, Guid>, IConsultantBankRepository
    {
        public ConsultantBankRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<bool> CheckAccountNumber(string? accountNumber, Guid? excludeId = null)
        {
            return await _context.ConsultantBanks.AnyAsync(a => a.AccountNumber.ToLower() == accountNumber.ToLower().Trim() &&
                (!excludeId.HasValue || a.ConsultantBankId != excludeId)
            );
        }

        public async Task<PaginatedResult<ConsultantBank>> GetAllConsultantBanksAsync(int page, int limit, string? search, bool? status)
        {
            search = search?.ToLower().Trim();
            IQueryable<ConsultantBank> query = _context.ConsultantBanks.Include(b => b.Bank).AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => s.ConsultantBankId.ToString().ToLower().Contains(search) ||
                                         s.ConsultantId.ToString().ToLower().Contains(search) ||
                                         s.BankId.ToString().ToLower().Contains(search) ||
                                         s.AccountNumber.ToLower().Contains(search) ||
                                         s.Consultant.AppUser.PhoneNumber.ToLower().Contains(search) ||
                                         s.Consultant.AppUser.Email.ToLower().Contains(search) ||
                                         EF.Functions.Collate(s.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search));
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
            return new PaginatedResult<ConsultantBank>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<ConsultantBank> GetConsultantBankByConsultant(Guid conSultantBankId)
        {
            var query = await _context.ConsultantBanks.Include(c => c.Bank)
            .FirstOrDefaultAsync(cb => cb.ConsultantBankId == conSultantBankId);
            return query;
        }

        public async Task<List<ConsultantBank>> GetConsultantBankByConsultantIdAsync(Guid consultantId)
        {
            return await _context.ConsultantBanks.Include(b => b.Bank)
                .Where(c => c.ConsultantId == consultantId)
                .OrderByDescending(c => c.IsDefault)
                .ToListAsync();
        }

        public async Task<ConsultantBank> GetConsultantBankById(Guid consultantBankId)
        {
            return await _context.ConsultantBanks.Include(b => b.Bank).FirstOrDefaultAsync(c => c.ConsultantBankId == consultantBankId);
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task SetDefaultBankAccountAsync(Guid consultantId)
        {
            var consultantBanks = await _context.ConsultantBanks
                .Where(cb => cb.ConsultantId == consultantId)
                .ToListAsync();
            if (consultantBanks.Any())
            {
                consultantBanks.ForEach(cb =>
                {
                    cb.IsDefault = false;
                    cb.UpdatedAt = DateTime.Now;
                });
            }
            await _context.SaveChangesAsync();
        }
    }
}
