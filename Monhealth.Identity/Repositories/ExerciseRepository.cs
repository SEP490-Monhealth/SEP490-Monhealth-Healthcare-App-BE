using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ExerciseRepository : GenericRepository<Exercise, Guid>, IExerciseRepository
    {
        public ExerciseRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Exercise>> GetAllExerciseAsync(int page, int limit, string? search, ExerciseType? exerciseType, bool? status)
        {
            IQueryable<Exercise> query = _context.Exercises.AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.ExerciseName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.ExerciseId.ToString().ToLower().Contains(search.ToLower()));
            }
            // filter exerciseType
            //if (!string.IsNullOrEmpty(exerciseType))
            //{
            //    query = query.Where(f => f.Category.CategoryName == exerciseType && f.Category.CategoryType == (CategoryType)1);
            //}
            query = query.Where(t => t.ExerciseType == exerciseType);
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            int totalItems = await query.CountAsync();
            // filter popular
            // if(popular == true)
            // {
            //     query = query.OrderByDescending(v => v.Views);
            // }
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Exercise>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<Exercise> GetExerciseByIdAsync(Guid exerciseId)
        {
            var exercise = _context.Exercises.FirstOrDefault(e => e.ExerciseId == exerciseId);
            // Neu exercise ton tai thi tang Views len 1
            // if (exercise != null)
            // {
            //     exercise.Views += 1;
            //     await _context.SaveChangesAsync();
            // }
            return exercise;
        }

        public async Task<Exercise> GetExerciseByNameAsync(string exerciseName)
        {
            return await _context.Exercises.FirstOrDefaultAsync(n => n.ExerciseName.ToLower().Trim().Equals(exerciseName.ToLower().Trim()));
        }

        public async Task<IEnumerable<Exercise>> GetExercisesByWorkoutIdAsync(Guid workoutId)
        {
            return await _context.WorkoutExercises
                .Include(we => we.Workout)
                .Where(we => we.WorkoutId == workoutId)

                .Select(we => we.Exercise)
                .ToListAsync();
        }



        public async Task<List<Exercise>> GetExerciseUserIdAsync(Guid userId)
        {
            return await _context.Exercises.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
