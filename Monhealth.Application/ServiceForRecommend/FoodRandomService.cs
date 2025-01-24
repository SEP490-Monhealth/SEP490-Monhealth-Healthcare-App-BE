using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodRandomService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly FoodFilterService _foodFilterService;
        private readonly ILogger<FoodRandomService> _logger;

        public FoodRandomService(
            IFoodRepository foodRepository,
            FoodFilterService foodFilterService,
            ILogger<FoodRandomService> logger)
        {
            _foodRepository = foodRepository;
            _foodFilterService = foodFilterService;
            _logger = logger;
        }

        public async Task<MealPlanDTO> GetMealPlanAsync(Guid userId)
        {
            var mealPlan = new MealPlanDTO
            {
                Breakfast = new MealDTO { MainDish = await GetRandomDishAsync("breakfast", "Main Dish", userId) },
                Lunch = new MealDTO
                {
                    MainDish = await GetRandomDishAsync("lunch", "Main Dish", userId),
                    SideDish = await GetRandomDishAsync("lunch", "Side Dish", userId),
                    Dessert = await GetRandomDishAsync("lunch", "Dessert", userId)
                },
                Dinner = new MealDTO
                {
                    MainDish = await GetRandomDishAsync("dinner", "Main Dish", userId),
                    SideDish = await GetRandomDishAsync("dinner", "Side Dish", userId),
                    Dessert = await GetRandomDishAsync("dinner", "Dessert", userId)
                }
            };

            return mealPlan;
        }

        private async Task<FoodDTO?> GetRandomDishAsync(string mealType, string dishType, Guid userId)
        {
            var filteredFoods = await _foodFilterService.GetFilterFoodAsync(userId, 1, 100, new List<string> { mealType }, new List<string> { dishType });

            if (filteredFoods == null || filteredFoods.Items == null || !filteredFoods.Items.Any())
            {
                _logger.LogInformation($"No foods found for MealType {mealType} with DishType {dishType} for user {userId}.");
                return null;
            }

            var random = new Random();
            var itemsList = filteredFoods.Items.ToList();
            var randomFood = itemsList[random.Next(itemsList.Count)];

            _logger.LogInformation($"Random food selected: {randomFood.FoodName} for MealType {mealType} and DishType {dishType}.");

            return new FoodDTO
            {
                FoodId = randomFood.FoodId,
                FoodName = randomFood.FoodName
            };
        }
    }

    public class MealPlanDTO
    {
        public MealDTO Breakfast { get; set; }
        public MealDTO Lunch { get; set; }
        public MealDTO Dinner { get; set; }
    }

    public class MealDTO
    {
        public FoodDTO? MainDish { get; set; }
        public FoodDTO? SideDish { get; set; }
        public FoodDTO? Dessert { get; set; }
    }

    public class FoodDTO
    {
        public Guid FoodId { get; set; }
        public string FoodName { get; set; } = string.Empty;
    }
}
