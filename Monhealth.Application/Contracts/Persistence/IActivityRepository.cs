using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IActivityRepository : IGenericRepository<Activity, Guid>
    {
        Task<List<Activity>> GetAllActivities();
        Task<Activity> GetActivitiesById(Guid activityId);
        Task<List<Activity>> GetActivitiesByUserId(Guid userId);
        Task<List<Activity>> GetActivitiesByDailyActivityId(Guid dailyActivityId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}
