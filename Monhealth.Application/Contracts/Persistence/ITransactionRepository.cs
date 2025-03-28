using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ITransactionRepository : IGenericRepository<Transaction, Guid>
    {
        Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit,
        TransactionType? type, StatusTransaction? status , string? search);
        Task<Transaction> GetTransactionByWalletId(Guid walletId);
        Task<Transaction>GetTransactionId(Guid transactionId);
        Task<int> SaveChangeAsync();
    }
}
