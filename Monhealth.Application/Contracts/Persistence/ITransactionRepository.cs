using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ITransactionRepository : IGenericRepository<Transaction, Guid>
    {
        Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit, TransactionType? type, string? search, StatusTransaction? status);
        Task<Transaction> GetTransactionById(Guid transactionId);
        Task<PaginatedResult<Transaction>> GetTransactionByWalletId(int page, int limit, Guid walletId);
        Task<Transaction> GetTransactionWhenUpdated(TransactionType transactionType, float amount, StatusTransaction status);
        Task<int> SaveChangeAsync();
    }
}
