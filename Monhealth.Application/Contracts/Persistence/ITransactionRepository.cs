using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ITransactionRepository : IGenericRepository<Transaction, Guid>
    {
        Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit, TransactionType? type, StatusTransaction? status);
        Task<Transaction> GetTransactionById(Guid transactionId);
        Task<List<Transaction>> GetTransactionByWalletId(Guid walletId);
        Task<int> SaveChangeAsync();
    }
}
