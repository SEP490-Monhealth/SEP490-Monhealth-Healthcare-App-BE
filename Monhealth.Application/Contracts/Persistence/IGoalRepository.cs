using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IGoalRepository : IGenericRepository<Goal, Guid>
    {
        Task<List<Goal>> GetGoalsByUserIdAsync(Guid userId);
        Task<Goal> GetCurrentGoalByUserIdAsync(Guid userId);
        Task<int> SaveChangeAsync();
        Task<Goal> GetByUserIdAsync(Guid userId);
        Task<Metric?> GetUserMetricByUserIdAsync(Guid userId);
        Task<GoalType?> GetGoalTypeByUserIdAsync(Guid userId);
        Task<float> GetActivityLevelByUserIdAsync(Guid userId);
        Task<Goal> CheckStatusGoal(Guid userId);

    }

}