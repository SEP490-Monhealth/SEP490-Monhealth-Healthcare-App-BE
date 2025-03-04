using Microsoft.EntityFrameworkCore;
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

        public async Task<List<WorkoutExercise>> GetWorkoutExercisesByWorkoutId(Guid? workoutId)
        {
            var workoutExercises = await _context.WorkoutExercises
            .Where(we => we.WorkoutId == workoutId)
            .Include(we => we.Exercise) 
            .ToListAsync();
            return workoutExercises;
        }

        public Task<int> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
