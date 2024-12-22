using System.Linq.Dynamic.Core;
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

        public async Task<Food> GetByIdWithCategoriesAsync(Guid foodId)
        {
            return await _context.Foods
        .Include(f => f.FoodCategories)
        .Include(f => f.FoodPortions)
        .FirstOrDefaultAsync(f => f.FoodId == foodId);
        }

        public async Task<List<Food>> GetFoodByCategoryName(string categoryName)
        {
            return await _context.Foods
            .Include(f => f.FoodCategories)
            .ThenInclude(fc => fc.Category)
            .Where(f => f.FoodCategories.Any(fc => fc.Category.CategoryName == categoryName))
            .ToListAsync();
        }
        public async Task<Food> GetFoodByIdAsync(Guid foodId)
        {
            return await _context.Foods
            .Include(f => f.FoodCategories).ThenInclude(fc => fc.Category)
            .FirstOrDefaultAsync(f => f.FoodId == foodId);
        }

        public async Task<Food> GetFoodByNameAsync(string foodName)
        {
            return await _context.Foods.FirstOrDefaultAsync(f => f.FoodName == foodName);
        }

        public async Task<List<Food>> GetFoodListByFoodType(string foodType)
        {
            return await _context.Foods.Where(f => f.FoodType == foodType)
            .Include(f => f.FoodCategories)
            .ThenInclude(fc => fc.Category).ToListAsync();

        }

        public void RemoveFoodCategories(Guid foodId)
        {
            var categoriesToRemove = _context.FoodCategories.Where(fc => fc.FoodId == foodId);
            _context.FoodCategories.RemoveRange(categoriesToRemove);
        }

        public void RemoveFoodPortions(Guid foodId)
        {
            var portionsToRemove = _context.FoodPortions.Where(fp => fp.FoodId == foodId);
            _context.FoodPortions.RemoveRange(portionsToRemove);
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
