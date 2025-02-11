using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class WorkoutExcerciseRepository : GenericRepository<WorkoutExercise, Guid>, IWorkoutExcerciseRepository
    {
        public WorkoutExcerciseRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public Task<int> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
