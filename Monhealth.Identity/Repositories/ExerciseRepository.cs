using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ExerciseRepository : GenericRepository<Exercise, Guid>, IExerciseRepository
    {
        public ExerciseRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Exercise>> GetAllExerciseAsync(int page, int limit, string? search, bool? popular, string? exerciseType)
        {
            IQueryable<Exercise> query = _context.Exercises.Include(t => t.Category).AsQueryable();
            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.ExerciseName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                    s.ExerciseId.ToString().ToLower().Contains(search.ToLower()));
            }
            // filter exerciseType
            if (!string.IsNullOrEmpty(exerciseType))
            {
                query = query.Where(f => f.Category.CategoryName == exerciseType && f.Category.CategoryType == "Exercise");
            }
            int totalItems = await query.CountAsync();
            // filter popular
            if(popular == true)
            {
                query = query.OrderByDescending(v => v.Views);
            }
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
            var exercise = _context.Exercises.Include(t => t.Category).FirstOrDefault(e => e.ExerciseId == exerciseId);
            // Neu exercise ton tai thi tang Views len 1
            if (exercise != null)
            {
                exercise.Views += 1;
                await _context.SaveChangesAsync();
            }
            return exercise;
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
