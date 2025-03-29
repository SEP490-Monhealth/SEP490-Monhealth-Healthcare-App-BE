using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public interface IWithdrawalRepository : IGenericRepository<WithdrawalRequest,Guid>
    {
        Task<int>SaveChangeASync();
    }
}