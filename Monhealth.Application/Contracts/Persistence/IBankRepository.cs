using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IBankRepository : IGenericRepository<Bank, Guid>
    {
        Task<PaginatedResult<Bank>> GetAllBanksAsync(int page, int limit, string? search, bool? status);
        Task<Bank> CheckBankNameExisted(string bankName);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
