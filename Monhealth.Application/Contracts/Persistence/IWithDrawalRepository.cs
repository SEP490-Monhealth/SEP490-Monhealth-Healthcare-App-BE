using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public interface IWithDrawalRepository : IGenericRepository<WithDrawalRequest,Guid>
    {
        Task<int>SaveChangeASync();
    }
}