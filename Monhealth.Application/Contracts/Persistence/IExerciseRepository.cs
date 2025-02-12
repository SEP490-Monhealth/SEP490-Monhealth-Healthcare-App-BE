using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IExerciseRepository : IGenericRepository<Exercise, Guid>
    {
        Task<PaginatedResult<Exercise>> GetAllExerciseAsync(int page, int limit, string? search, ExerciseType? exerciseType, bool? status);
        Task<Exercise> GetExerciseByIdAsync(Guid exerciseId);
        Task<List<Exercise>> GetExerciseUserIdAsync(Guid userId);
        Task<Exercise> GetExerciseByNameAsync(string exerciseName);
        Task<IEnumerable<Exercise>> GetExercisesByWorkoutIdAsync(Guid workoutId);
        Task<int> SaveChangeAsync();
    }
}
