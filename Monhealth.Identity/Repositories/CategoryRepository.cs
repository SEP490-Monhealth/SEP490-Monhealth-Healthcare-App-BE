using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
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

        public async Task<Category> GetCategoryByCategoryName(string Name)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.CategoryName == Name);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}