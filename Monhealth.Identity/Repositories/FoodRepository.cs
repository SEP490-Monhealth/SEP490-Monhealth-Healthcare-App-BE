using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class FoodRepository : GenericRepository<Food, Guid>, IFoodRepository
    {
        public FoodRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Food>> GetAllFoodAsync()
        {
            var foods = await _context.Foods.Include(f => f.FoodCategories)
            .ThenInclude(fc => fc.Category)
            .ToListAsync();
            return foods;
        }

        public async Task<List<Food>> GetByIdsAsync(IEnumerable<Guid> foodIds)
        {
            return await _context.Foods
                         .Include(f => f.FoodPortions)
                         .Where(f => foodIds.Contains(f.FoodId))
                         .ToListAsync();
        }

        public async Task<List<Food>> GetFoodListByFoodType(string foodType)
        {
            return await _context.Foods.Where(f => f.FoodType == foodType)
            .Include(f => f.FoodCategories)
            .ThenInclude(fc => fc.Category).ToListAsync();

        }

        // public async Task<List<Food>> GetFoodListByUser(Guid userId)
        // {
        //     var isCustomer = await _context.Roles.Where(role => role.Name == "Customer")
        //                         .Join(_context.UserRoles,
        //                               role => role.Id,
        //                               userRole => userRole.RoleId,
        //                               (role, userRole) => userRole.UserId)
        //                         .Distinct()
        //                         .ToListAsync();
        //     if (isCustomer == null)
        //     {

        //         return new List<Food>();
        //     }


        //     var foods = await _context.Foods
        //         .Where(f => f.UserId == userId)
        //         .ToListAsync();

        //     return foods;
        // }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
