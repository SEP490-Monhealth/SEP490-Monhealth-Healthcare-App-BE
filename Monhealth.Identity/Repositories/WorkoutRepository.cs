using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
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

        public async Task<PaginatedResult<Workout>> GetAllWorkWithPaging(int page, int limit, string? category, string? search, DifficultyLevel? difficulty, bool? popular, bool? status, CancellationToken cancellationToken)
        {
            search = search?.Trim();
            IQueryable<Workout> query = _context.Workouts.Include(f => f.Category).
            Include(f => f.WorkoutExercises).ThenInclude(we => we.Exercise).AsQueryable();

            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.WorkoutName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.WorkoutId.ToString().ToLower().Contains(search.ToLower()));
            }
            if (!string.IsNullOrEmpty(category))
                query = query.Where(f => f.Category.CategoryName.ToLower() == category.ToLower());

            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            if (difficulty.HasValue)
            {
                query = query.Where(s => s.DifficultyLevel == difficulty.Value);
            }

            if (popular.HasValue && popular.Value)
            {
                query = query.OrderByDescending(s => s.Views);
            }
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Workout>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<Workout> GetWorkoutByIdAsync(Guid workoutId)
        {
            return await _context.Workouts.Include(w => w.WorkoutExercises).ThenInclude(we => we.Exercise).FirstOrDefaultAsync(w => w.WorkoutId == workoutId);
        }

        public async Task<List<Workout>> GetWorkoutsByUser(Guid userId)
        {
            IQueryable<Workout> queries = _context.Workouts.Where(f => f.UserId == userId).Include(f => f.Category).
            Include(f => f.WorkoutExercises).ThenInclude(we => we.Exercise).AsQueryable();
            return await queries.ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
