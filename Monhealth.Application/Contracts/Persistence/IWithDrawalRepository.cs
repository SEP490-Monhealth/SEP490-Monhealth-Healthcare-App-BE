using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public interface IWithdrawalRepository : IGenericRepository<WithdrawalRequest, Guid>
    {
        Task<int> SaveChangeASync();
        Task<PaginatedResult<WithdrawalRequest>> GetAllWithdrawalRequestAsync(int page , int limit , WithdrawalStatus? status);
        Task<WithdrawalRequest> GetWithdrawalRequest(Guid withdrawalId);
    }
}