using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class WorkoutRepository : GenericRepository<Workout, Guid>, IWorkoutRepository
    {
        public WorkoutRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<bool> ExistWorkoutName(string workoutName, Guid userId)
        {
            return await _context.Workouts.AnyAsync(w => w.WorkoutName.ToLower() == workoutName.ToLower() && w.UserId == userId);
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);

        }


    }
}
