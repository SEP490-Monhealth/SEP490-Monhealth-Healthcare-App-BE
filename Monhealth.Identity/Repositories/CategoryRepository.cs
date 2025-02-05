using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class CategoryRepository : GenericRepository<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<bool> AnyAsync(Expression<Func<Category, bool>> predicate)
        {
            return await _context.Set<Category>().AnyAsync(predicate);
        }

        public async Task<List<Category>> GetAllCategoryAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesByType(CategoryType categoryType)
        {
            return await _context.Categories
                .Where(c => c.CategoryType == categoryType)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryByCategoryName(string name)
        {
            return await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryName.ToLower() == name.ToLower());
        }

        public async Task<List<Guid>> GetCategoryIdsByNamesAsync(IEnumerable<string> categoryNames)
        {
            return await _context.Categories
                       .Where(c => categoryNames.Contains(c.CategoryName.ToLower()))
                       .Select(c => c.CategoryId)
                       .ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
