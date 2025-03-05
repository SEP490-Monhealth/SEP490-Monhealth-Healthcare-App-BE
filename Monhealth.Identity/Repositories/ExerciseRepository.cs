using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
using System.ComponentModel.DataAnnotations;

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
            if (exerciseType.HasValue)
            {
                query = query.Where(e => e.ExerciseType == exerciseType);
            }
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

        public async Task<IEnumerable<Exercise>> GetExercisesByListId(List<Guid> exerciseIdList)
        {
            var exercises = await _context.Exercises.
                Where(e => exerciseIdList.Contains(e.ExerciseId))
                .Include(e => e.WorkoutExercises).ThenInclude(we => we.Workout)
                .OrderBy(e => e.WorkoutExercises.Min(we => we.Order))
                .ToListAsync();
            return exercises;
        }

        public async Task<IEnumerable<Exercise>> GetExercisesByWorkoutIdAsync(Guid workoutId)
        {
            return await _context.Exercises
             .Where(e => e.WorkoutExercises.Any(we => we.WorkoutId == workoutId)) // Filter Exercises with WorkoutId
             .OrderBy(e => e.WorkoutExercises
                .Where(we => we.WorkoutId == workoutId)
                    .Min(we => we.Order)) // Order by Min(Order)
             .Select(e => new Exercise
             {
                 ExerciseId = e.ExerciseId,
                 UserId = e.UserId,

                 ExerciseName = e.ExerciseName,
                 ExerciseType = e.ExerciseType,
                 CaloriesPerMinute = e.CaloriesPerMinute,
                 Instructions = e.Instructions,
                 Status = e.Status,
                 CreatedAt = e.CreatedAt,
                 UpdatedAt = e.UpdatedAt,
                 WorkoutExercises = e.WorkoutExercises
                 .Where(we => we.WorkoutId == workoutId && we.ExerciseId == e.ExerciseId) // Only include filtered WorkoutExercises
                 .ToList()
             })
             .ToListAsync();

        }

        [Key]
        public Guid ExerciseId { get; set; }
        public Guid UserId { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public string ExerciseName { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public float CaloriesPerMinute { get; set; }
        public bool Status { get; set; }

        public async Task<List<Exercise>> GetExerciseUserIdAsync(Guid userId)
        {
            return await _context.Exercises.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Workout>> GetWorkoutByWorkoutType(Workout workout)
        {
            return await _context.Workouts.Where(w => w.CategoryId == workout.CategoryId &&
            w.WorkoutType == Core.Enum.WorkoutType.Warmup
            && w.DifficultyLevel == workout.DifficultyLevel
            )
                .Include(w => w.WorkoutExercises).ThenInclude(we => we.Exercise)
                .OrderBy(e => e.WorkoutExercises.Where(we => we.WorkoutId == workout.WorkoutId).Min(we => we.Order))
                .ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
