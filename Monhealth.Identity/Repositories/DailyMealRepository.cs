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
                .Include(dl => dl.Goal)
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
                        .OrderBy(m => mealTypeOrder.TryGetValue(m.MealType.ToString(), out var order) ? order : int.MaxValue)
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
                    .OrderBy(m => mealTypeOrder.TryGetValue(m.MealType.ToString(), out var order) ? order : int.MaxValue)
                    .ToList();
            }

            return dailyMeal;
        }

        public async Task<DailyMeal> GetDailyMealByDailyMealDate(DateTime dailyMealDate)
        {
            return await _context.DailyMeals.FirstOrDefaultAsync(d => d.DailyMealDate == dailyMealDate);
        }

        public async Task<DailyMeal> GetDailyMealByIdAsync(Guid dailyMealId, CancellationToken cancellationToken)
        {
            return await _context.DailyMeals
            .Include(dm => dm.Meals)
            .FirstOrDefaultAsync(dm => dm.DailyMealId == dailyMealId, cancellationToken);
        }

        public Task<DailyMeal> GetDaiLyMealByUser(Guid UserId, DateTime DateTime)
        {
            return _context.DailyMeals.Include(dl => dl.Meals).ThenInclude(m => m.MealFoods)
            .FirstOrDefaultAsync(dl => dl.UserId == UserId && dl.DailyMealDate == DateTime);
        }

        public async Task<DailyMeal> GetDailyMealByUserAndDate(DateTime createAt, Guid userID)
        {
            return await _context.DailyMeals.FirstOrDefaultAsync
            (d => d.DailyMealDate == createAt && d.UserId == userID);
        }

        public async Task<IEnumerable<DailyMeal>> GetDailyMealsAfterDate(Guid userId, DateTime date)
        {
            return await _context.DailyMeals.Include(dl => dl.Meals)
                                   .Where(dm => dm.UserId == userId && dm.DailyMealDate > date)
                                   .ToListAsync();
        }

        public async Task<DailyMeal> GetDailyMealsByCreateAt(DateTime createAt)
        {
            return await _context.DailyMeals.FirstOrDefaultAsync(d => d.CreatedAt.Value.Date == createAt.Date);
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
                .Include(m => m.Goal)
                .Where(dl => dl.DailyMealDate.Date == createAt.Date)
                // .Where(dl => dl.DailyMealDate.Month == createAt.Month)
                // .Where(dl => dl.DailyMealDate.Year == createAt.Year)
                .FirstOrDefaultAsync(dl => dl.UserId == userId);

            // Kiểm tra nếu DailyMeal tồn tại và sắp xếp Meals
            if (dailyMeal != null && dailyMeal.Meals != null)
            {
                dailyMeal.Meals = dailyMeal.Meals
                    .OrderBy(m => mealTypeOrder.TryGetValue(m.MealType.ToString(), out var order) ? order : int.MaxValue)
                    .ToList();
            }

            return dailyMeal; // Trả về một đối tượng DailyMeal
        }

        public async Task<List<DailyMeal>> GetDailyMealsReportByUserAndDate(Guid userId, DateTime date)
        {
            // Lấy tất cả DailyMeal của user mà trường CreatedAt không null (cùng với các include cần thiết)
            var userDailyMealsQuery = _context.DailyMeals
                .Include(dm => dm.Meals)
                    .ThenInclude(m => m.MealFoods)
                        .ThenInclude(mf => mf.Food)
                            .ThenInclude(f => f.FoodPortions)
                .Where(dm => dm.UserId == userId && dm.CreatedAt.HasValue);

            // Nếu không có bản ghi nào có CreatedAt tồn tại, trả về null.
            if (!await userDailyMealsQuery.AnyAsync())
            {
                return null;
            }

            int daysSinceMonday = ((int)date.DayOfWeek + 6) % 7;
            DateTime startOfWeek = date.Date.AddDays(-daysSinceMonday); // Ngày thứ Hai của tuần
            DateTime endOfWeek = startOfWeek.AddDays(6);                  // Ngày Chủ nhật của tuần

            // --- LỌC DỮ LIỆU THEO TUẦN ---
            var dailyMealsInWeek = await userDailyMealsQuery
                .Where(dm => dm.CreatedAt.Value.Date >= startOfWeek && dm.CreatedAt.Value.Date <= endOfWeek)
                .ToListAsync();

            // Nếu không có bản ghi nào trong khoảng tuần, trả về null.
            if (dailyMealsInWeek == null || dailyMealsInWeek.Count == 0)
            {
                return null;
            }

            return dailyMealsInWeek;
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}