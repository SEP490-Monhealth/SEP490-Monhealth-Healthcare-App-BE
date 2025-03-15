using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Repositories;

namespace Monhealth.Identity
{
    public class DishTypeRepository : GenericRepository<DishType, Guid>, IDishTypeRepository
    {
        public DishTypeRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task DeleteDishTypeFoods(Guid id)
         => await _context
            .DishTypeFoods
            .Where(dt => dt.FoodId == id)
            .ExecuteDeleteAsync();

        public async Task<List<DishType>> GetDishTypesByNames(string[] names)
            => await _context.DishTypes
                .AsNoTracking()
                .Where(dt => names.Contains(dt.DishTypeName))
                .ToListAsync();
    }
}