using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ITransactionRepository : IGenericRepository<Transaction, Guid>
    {
        Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit);
        Task<Transaction> GetTransactionByWalletId(Guid walletId);
        Task<int> SaveChangeAsync();
    }
}
