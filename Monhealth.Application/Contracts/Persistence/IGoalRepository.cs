using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IGoalRepository : IGenericRepository<Goal, Guid>
    {
        Task<List<Goal>> GetGoalsByUserIdAsync(Guid userId);
        Task<int> SaveChangeAsync();
        Task<Goal> GetByUserIdAsync(Guid userId);
    }
}
