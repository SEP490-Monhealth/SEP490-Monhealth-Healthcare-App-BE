using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDailyActivityRepository : IGenericRepository<DailyActivity, Guid>
    {
        Task<DailyActivity> GetDailyActivityByUserIdAndCreateAt(Guid userId, DateTime today);
        Task<int> SaveChangeAsync();
    }
}
