using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
namespace Monhealth.Application.Features.Meal.RecommendMealForUser.SupportFunction
{
    public class FilterFoodListHandler
    {
        private readonly IUserAllergyRepository _userAllergyRepository;
        private readonly ILogger<FilterFoodListHandler> _logger;
        private readonly IFoodRepository _foodRepository;
        public FilterFoodListHandler(IUserAllergyRepository userAllergyRepository,
        ILogger<FilterFoodListHandler> logger,
        IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
            _userAllergyRepository = userAllergyRepository;
            _logger = logger;
        }

        public async Task<List<Domain.Food>> FilterFoodListQueryHandler(Guid userId)
        {
            var userAllergyIds = await _userAllergyRepository.GetUserAllergiesByUserId(userId);
            var allergyIds = userAllergyIds?.Select(a => a.AllergyId).ToList() ?? new List<Guid>();

            var mealTypesToFilter = new List<int> {
                (int)MealType.Breakfast,
                (int)MealType.Lunch,
                (int)MealType.Dinner
            };
            var dishTypesToFilter = new List<int> {
                (int)DishTypeEnum.MainDish,
                (int)DishTypeEnum.SideDish,
            };

            var allFoods = await _foodRepository.GetAll().Include(f => f.FoodPortions)
                .ThenInclude(f => f.Portion)
                .Include(f => f.Nutrition)
                .Where(f => !f.FoodAllergies.Any(fa => allergyIds.Contains(fa.AllergyId)))
                .ToListAsync();

            // Log the number of foods retrieved
            _logger.LogInformation($"Total foods fetched from repository: {allFoods.Count}");

            var filteredFoods = allFoods
     .Where(f =>
         (mealTypesToFilter == null || !mealTypesToFilter.Any() || f.MealType.Select(fmt => (int)fmt).Any(mt => mealTypesToFilter.Contains(mt)))
     )
     .ToList();
            return filteredFoods;
        }
    }
}