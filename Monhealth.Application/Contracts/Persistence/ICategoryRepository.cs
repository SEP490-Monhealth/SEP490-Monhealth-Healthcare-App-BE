using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using System.Linq.Expressions;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IGenericRepository<Category, Guid>
    {
        Task<PaginatedResult<Category>> GetAllCategoryAsync(int page , int limit , string search , CategoryType? categoryType);  
        Task<bool> AnyAsync(Expression<Func<Category, bool>> predicate);
        Task<int> SaveChangeAsync();
        Task<Category> GetCategoryByCategoryName(string Name);
        Task<List<Category>> GetCategoriesByType(CategoryType categoryType);
        Task<List<Guid>> GetCategoryIdsByNamesAsync(IEnumerable<string> categoryNames);
        Task<List<Category>>GetCategoriesByList(List<string> categories);
    }
}