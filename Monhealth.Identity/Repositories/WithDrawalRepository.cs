using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Repositories;

namespace Monhealth.Application
{
    public class WithdrawalRepository : GenericRepository<WithdrawalRequest, Guid>, IWithdrawalRepository
    {
        public WithdrawalRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<WithdrawalRequest>> GetAllWithdrawalRequestAsync(int page, int limit,
        WithdrawalStatus? status, string? search)
        {
            search = search?.ToLower().Trim();
            var query = _context.WithdrawalRequests.Include(wd => wd.Consultant)
            .ThenInclude(u => u.AppUser)
            .Include(b => b.Consultant).ThenInclude(c => c.ConsultantBanks)
            .ThenInclude(b => b.Bank)
            .Include(c => c.Consultant).ThenInclude(cs => cs.Wallet)
            .ThenInclude(cs => cs.Transactions).AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(wd =>
                    wd.WithdrawalRequestId.ToString().Contains(search) ||
                    wd.ConsultantId.ToString().Contains(search) ||
                    EF.Functions.Collate(wd.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search) ||
                    wd.Consultant.AppUser.Email.ToLower().Contains(search) ||
                    wd.Consultant.AppUser.PhoneNumber.ToLower().Contains(search));
            }

            if (status.HasValue)
            {
                query = query.Where(wd => wd.Status == status);
            }
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var totalItems = await query.CountAsync();
            return new PaginatedResult<WithdrawalRequest>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };

        }

        public async Task<WithdrawalRequest> GetWithdrawalRequest(Guid withdrawalId)
        {
            return await _context.WithdrawalRequests.Include(wd => wd.Consultant)
                .ThenInclude(u => u.AppUser)
            .Include(b => b.Consultant).ThenInclude(c => c.ConsultantBanks)
                .ThenInclude(b => b.Bank)
            .Include(c => c.Consultant).ThenInclude(cs => cs.Wallet)
                .ThenInclude(cs => cs.Transactions).FirstOrDefaultAsync(wd => wd.WithdrawalRequestId == withdrawalId);
        }

        public async Task<PaginatedResult<WithdrawalRequest>> GetWithdrawRequestByConsultant(Guid consultant, int page, int limit)
        {
            var query = _context.WithdrawalRequests.Include(wd => wd.Consultant)
            .ThenInclude(u => u.AppUser)
            .Include(b => b.Consultant).ThenInclude(c => c.ConsultantBanks)
            .ThenInclude(b => b.Bank)
            .Include(c => c.Consultant).ThenInclude(cs => cs.Wallet)
            .ThenInclude(cs => cs.Transactions).AsQueryable()
            .Where(cs => cs.ConsultantId == consultant)
              .OrderByDescending(cs => cs.CreatedAt);;

            if (page > 0 && limit > 0)
            {
                query = (IOrderedQueryable<WithdrawalRequest>)query.Skip((page - 1) * limit).Take(limit);
            }

            var totalItems = await query.CountAsync();
            return new PaginatedResult<WithdrawalRequest>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };

        }

        public async Task<int> SaveChangeASync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}