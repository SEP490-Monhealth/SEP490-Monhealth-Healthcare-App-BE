using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWorkoutExcerciseRepository : IGenericRepository<WorkoutExercise, Guid>
    {
        Task<int> SaveChangeAsync();

    }
}
