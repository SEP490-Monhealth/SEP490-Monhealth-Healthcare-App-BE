using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IActivityRepository : IGenericRepository<Activity, Guid>
    {
        Task<int> SaveChangeAsync();
    }
}
