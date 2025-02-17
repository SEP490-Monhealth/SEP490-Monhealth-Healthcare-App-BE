using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWorkoutRepository : IGenericRepository<Workout, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<bool> ExistWorkoutName(string workoutName, Guid userId);
        Task<PaginatedResult<Workout>> GetAllWorkWithPaging(int page, int limit, string? category, string? search, DifficultyLevel? difficulty, bool? popular, bool? status, CancellationToken cancellationToken);
        Task<Workout> GetWorkoutByIdAsync(Guid workoutId);
    }
}
