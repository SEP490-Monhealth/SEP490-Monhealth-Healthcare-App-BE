using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWorkoutExcerciseRepository : IGenericRepository<WorkoutExercise, Guid>
    {
        Task<List<WorkoutExercise>> GetWorkoutExercisesByWorkoutId(Guid? workoutId);
        Task<int> SaveChangeAsync();

    }
}
