using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IWorkoutRepository : IGenericRepository<Workout, Guid>
    {
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
        Task<bool> ExistWorkoutName(string workoutName, Guid userId);
    }
}
