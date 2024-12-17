using Monhealth.Domain;
using System.Linq.Expressions;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IGenericRepository<Category, Guid>
    {
        Task<List<Category>> GetAllCategoryAsync();
        Task<bool> AnyAsync(Expression<Func<Category, bool>> predicate);
        Task<int> SaveChangeAsync();
    }
}