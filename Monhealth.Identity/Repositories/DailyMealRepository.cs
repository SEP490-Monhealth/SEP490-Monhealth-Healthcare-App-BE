using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class DailyMealRepository : GenericRepository<DailyMeal, Guid>, IDailyMealRepository
    {
        public DailyMealRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<DailyMeal>> GetAllDailyMeals()
        {
            // Lấy danh sách DailyMeals từ cơ sở dữ liệu, bao gồm các liên kết cần thiết
            var orderedDailyMeals = await _context.DailyMeals
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.FoodPortions)
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.Nutrition)
                .ToListAsync();

            // Định nghĩa thứ tự ưu tiên cho MealType
            var mealTypeOrder = new Dictionary<string, int>
    {
        { "Breakfast", 1 },
        { "Lunch", 2 },
        { "Dinner", 3 },
        { "Snack", 4 }
    };

            // Sắp xếp danh sách Meals trong mỗi DailyMeal
            foreach (var dailyMeal in orderedDailyMeals)
            {
                // Kiểm tra nếu danh sách Meals không null
                if (dailyMeal.Meals != null)
                {
                    dailyMeal.Meals = dailyMeal.Meals
                        .OrderBy(m => mealTypeOrder.TryGetValue(m.MealType, out var order) ? order : int.MaxValue)
                        .ToList(); // Chuyển sang List sau khi sắp xếp
                }
            }

            return orderedDailyMeals; // Trả về danh sách DailyMeals đã sắp xếp
        }



        public async Task<DailyMeal> GetDailyMealByCreateAt(DateTime createAt)
        {

            var mealTypeOrder = new Dictionary<string, int>
    {
        { "Breakfast", 1 },
        { "Lunch", 2 },
        { "Dinner", 3 },
        { "Snack", 4 }
    };


            var dailyMeal = await _context.DailyMeals
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.FoodPortions)
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.Nutrition)
                .FirstOrDefaultAsync(dl => dl.CreatedAt == createAt);


            if (dailyMeal != null && dailyMeal.Meals != null)
            {
                dailyMeal.Meals = dailyMeal.Meals
                    .OrderBy(m => mealTypeOrder.TryGetValue(m.MealType, out var order) ? order : int.MaxValue)
                    .ToList();
            }

            return dailyMeal;
        }

        public async Task<DailyMeal> GetDailyMealByIdAsync(Guid dailyMealId, CancellationToken cancellationToken)
        {
            return await _context.DailyMeals
            .Include(dm => dm.Meals)
            .FirstOrDefaultAsync(dm => dm.DailyMealId == dailyMealId, cancellationToken);
        }

        public async Task<DailyMeal> GetDailyMealByUserAndDate(DateTime createAt, Guid userID)
        {
            return await _context.DailyMeals.FirstOrDefaultAsync
            (d => d.CreatedAt == createAt && d.UserId == userID);
        }

        public async Task<DailyMeal> GetDailyMealsByUser(Guid userId, DateTime createAt)
        {
            var mealTypeOrder = new Dictionary<string, int>
    {
        { "Breakfast", 1 },
        { "Lunch", 2 },
        { "Dinner", 3 },
        { "Snack", 4 }
    };

            // Lấy một DailyMeal duy nhất từ cơ sở dữ liệu
            var dailyMeal = await _context.DailyMeals
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.FoodPortions)
                .Include(dl => dl.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.Nutrition)
                .FirstOrDefaultAsync(dl => dl.UserId == userId && dl.CreatedAt == createAt.Date);

            // Kiểm tra nếu DailyMeal tồn tại và sắp xếp Meals
            if (dailyMeal != null && dailyMeal.Meals != null)
            {
                dailyMeal.Meals = dailyMeal.Meals
                    .OrderBy(m => mealTypeOrder.TryGetValue(m.MealType, out var order) ? order : int.MaxValue)
                    .ToList();
            }

            return dailyMeal; // Trả về một đối tượng DailyMeal
        }


        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}