using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IExerciseRepository : IGenericRepository<Exercise, Guid>
    {
        Task<PaginatedResult<Exercise>> GetAllExerciseAsync(int page, int limit, string? search, bool? popular, string? type);
        Task<Exercise> GetExerciseByIdAsync(Guid exerciseId);
        Task<int> SaveChangeAsync();
    }
}
