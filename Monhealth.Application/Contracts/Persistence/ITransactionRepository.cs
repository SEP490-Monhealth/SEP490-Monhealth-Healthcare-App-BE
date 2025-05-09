﻿using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
  public interface ITransactionRepository : IGenericRepository<Transaction, Guid>
  {
    Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit, TransactionType? type, string? search, StatusTransaction? status);
    Task<Transaction> GetTransactionById(Guid transactionId);
    Task<List<Transaction>> GetTransactionByConsultantId(Guid transactionId, DateTime date);
    Task<PaginatedResult<Transaction>> GetTransactionByCreatedBy(Guid userId, int page, int limit);
    Task<PaginatedResult<Transaction>> GetTransactionByWalletId(int page, int limit, Guid walletId, StatusTransaction? status);
    Task<PaginatedResult<Transaction>> GetAllTransactionByConsultantId(int page, int limit, Guid Consultant, string month);
    Task<Transaction> GetTransactionWhenUpdated(TransactionType transactionType, float amount, StatusTransaction status);
    Task<List<Transaction>> GetTransactionsByConsultantAndDateRange(Guid consultantId, DateTime from, DateTime to);
    Task<Transaction> GetTransactionByOrderCode(long orderCode);
    Task<List<Transaction>> GetTransactionBySubscriptionId(Guid subscriptionId);
    Task<int> SaveChangeAsync();
    Task<decimal> GetTotalTransactionAmountWithTypeAsync(
               TransactionType type);
    Task<decimal> GetTotalTransactionAmountWithTypeAsync(
    TransactionType type, DateTime createdAt);
    Task<Transaction> GetTransactionByBookingId(Guid bookingId);
    Task ExpireTransactions(Guid[] transactionIds);
  }
}
