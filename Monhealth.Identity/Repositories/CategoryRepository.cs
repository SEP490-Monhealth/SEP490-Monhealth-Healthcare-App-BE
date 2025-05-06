using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System.Linq.Expressions;

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

        public async Task<PaginatedResult<Category>> GetAllCategoryAsync(int page, int limit, string search, CategoryType? categoryType)
        {
            IQueryable<Category> query = _context.Categories.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => EF.Functions.Collate(c.CategoryName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) 
                                      || c.CategoryId.ToString().ToLower().Contains(search.ToLower().Trim()));

            }
            if (categoryType.HasValue)
            {
                query = query.Where(c => c.CategoryType == categoryType);
            }
            
            var totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            return new PaginatedResult<Category>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Category>> GetCategoriesByList(List<string> categories)
        {
            return await _context.Categories
            .Where(c => categories.Contains(c.CategoryName)).ToListAsync();
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
                .FirstOrDefaultAsync(c => c.CategoryName.ToLower() == name.ToLower().Trim());
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
