using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IActivityRepository : IGenericRepository<Activity, Guid>
    {
        Task<List<Activity>> GetActivitiesByUserId(Guid userId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
