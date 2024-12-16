using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
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

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}