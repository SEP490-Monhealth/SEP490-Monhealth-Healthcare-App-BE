using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Food.AddFood;
using Monhealth.Application.ServiceForRecommend.DTO;
using Monhealth.Application.Services;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.ServiceForRecommend
{
    public class FoodRandomService
    {
        private readonly IFoodRepository _foodRepository;
        private readonly FoodFilterService _foodFilterService;
        private readonly GoalService _goalService;
        private readonly ILogger<FoodRandomService> _logger;

        public FoodRandomService(
            IFoodRepository foodRepository,
            FoodFilterService foodFilterService,
            GoalService goalService,
            ILogger<FoodRandomService> logger)
        {
            _foodRepository = foodRepository;
            _foodFilterService = foodFilterService;
            _goalService = goalService;
            _logger = logger;
        }

        public async Task<MealPlanWithAllocationDTO> GetMealPlanWithAllocationAsync(Guid userId, float activityLevel)
        {
            // 🔹 Lấy GoalType của user từ database
            var goalType = await _goalService.GetGoalTypeByUserIdAsync(userId);
            if (goalType == null)
            {
                _logger.LogWarning($"⚠️ Không tìm thấy GoalType cho user {userId}. Sử dụng mặc định: Maintenance.");
                goalType = GoalType.Maintenance; // Nếu không có, mặc định là Maintenance
            }

            var mealAllocations = await _goalService.GetMealAllocationByUserIdAsync(userId);

            if (mealAllocations == null || !mealAllocations.Any())
            {
                _logger.LogWarning($"⚠️ Không tìm thấy goal allocation cho user {userId}.");
                return new MealPlanWithAllocationDTO(); // Trả về rỗng
            }

            _logger.LogInformation($"✅ Tạo Meal Plan cho user {userId} với {mealAllocations.Count} loại bữa ăn.");

            // 🔹 Tạo bữa ăn cho từng loại meal
            var breakfast = mealAllocations.TryGetValue("breakfast", out var breakfastAllocation)
                ? await GenerateMealAsync(MealType.Breakfast, breakfastAllocation, userId, activityLevel)
                : null;

            var lunch = mealAllocations.TryGetValue("lunch", out var lunchAllocation)
                ? await GenerateMealAsync(MealType.Lunch, lunchAllocation, userId, activityLevel)
                : null;

            var dinner = mealAllocations.TryGetValue("dinner", out var dinnerAllocation)
                ? await GenerateMealAsync(MealType.Dinner, dinnerAllocation, userId, activityLevel)
                : null;

            var snack = mealAllocations.TryGetValue("snack", out var snackAllocation)
                ? await GenerateMealAsync(MealType.Snack, snackAllocation, userId, activityLevel)
                : null;

            return new MealPlanWithAllocationDTO
            {
                Breakfast = breakfast,
                Lunch = lunch,
                Dinner = dinner,
                Snack = snack
            };
        }


        private async Task<MealDTO> GenerateMealAsync(MealType mealType, MealAllocationDTO allocation, Guid userId, float activityLevel)
        {
            _logger.LogInformation($"🔍 Bắt đầu tạo {mealType} cho user {userId}...");

            // 🔹 Lấy tỷ lệ món ăn dựa trên CaloriesTarget
            var (mainDishRatio, sideDishRatio, soupRatio, dessertRatio, snackRatio) =
                await GetMealRatiosAsync(userId, mealType, activityLevel);

            // 🔹 Kiểm tra tổng calorie của bữa ăn
            float totalMealCalories = allocation.Calories;

            // 🔹 Lấy món chính trước, đây là món quan trọng nhất
            var mainDish = await GetRandomDishWithPortionAsync(mealType, DishType.MainDish, userId, allocation, mainDishRatio);
            float currentCalories = mainDish?.Food?.Calories ?? 0;

            // 🔹 Nếu món chính chiếm gần hết calorie => Giảm các món khác
            if (currentCalories >= totalMealCalories * 0.8f)
            {
                _logger.LogInformation($"⚠️ Món chính chiếm quá nhiều calories, giảm tỷ lệ món phụ.");
                sideDishRatio *= 0.5f;
                soupRatio *= 0.5f;
                dessertRatio *= 0.5f;
                snackRatio *= 0.5f;
            }

            // 🔹 Lấy các món phụ, chỉ nếu còn đủ calorie
            DishDTO? sideDish = null;
            if (sideDishRatio > 0 && currentCalories < totalMealCalories)
            {
                sideDish = await GetRandomDishWithPortionAsync(mealType, DishType.SideDish, userId, allocation, sideDishRatio, mainDish);
                currentCalories += sideDish?.Food?.Calories ?? 0;
            }

            DishDTO? soup = null;
            if (soupRatio > 0 && currentCalories < totalMealCalories)
            {
                soup = await GetRandomDishWithPortionAsync(mealType, DishType.Soup, userId, allocation, soupRatio);
                currentCalories += soup?.Food?.Calories ?? 0;
            }

            DishDTO? dessert = null;
            if (dessertRatio > 0 && currentCalories < totalMealCalories)
            {
                dessert = await GetRandomDishWithPortionAsync(mealType, DishType.Dessert, userId, allocation, dessertRatio);
                currentCalories += dessert?.Food?.Calories ?? 0;
            }

            DishDTO? snack = null;
            if (snackRatio > 0 && currentCalories < totalMealCalories)
            {
                snack = await GetRandomDishWithPortionAsync(mealType, DishType.Snack, userId, allocation, snackRatio);
                currentCalories += snack?.Food?.Calories ?? 0;
            }

            // 🔹 Trả về MealDTO đã được tạo
            return new MealDTO
            {
                MainDish = mainDish,
                SideDish = sideDish,
                Soup = soup,
                Dessert = dessert,
                Snack = snack
            };
        }



        private async Task<(float mainDish, float sideDish, float soup, float dessert, float snack)>
GetMealRatiosAsync(Guid userId, MealType mealType, float activityLevel)
        {
            var userGoals = await _goalService.GetGoalsByUserIdAsync(userId);

            // Kiểm tra nếu không có mục tiêu hoặc mục tiêu không hợp lệ
            if (userGoals == null)
            {
                _logger.LogWarning($"⚠️ Không tìm thấy mục tiêu cho user {userId}. Sử dụng CaloriesGoal mặc định.");
                float defaultCaloriesGoal = 2000; // Giá trị mặc định
                return GetMealRatiosFromCaloriesGoal(defaultCaloriesGoal, mealType);
            }

            var caloriesGoal = userGoals.CaloriesGoal;

            // Nếu CaloriesGoal không hợp lệ, sử dụng giá trị mặc định
            if (caloriesGoal <= 0)
            {
                _logger.LogWarning($"⚠️ CaloriesGoal không hợp lệ cho user {userId}. Sử dụng giá trị mặc định.");
                caloriesGoal = 2000; // Giá trị mặc định nếu CaloriesGoal không hợp lệ
            }

            // 🔹 Xác định tỷ lệ khẩu phần ăn theo từng bữa và CaloriesGoal
            return GetMealRatiosFromCaloriesGoal(caloriesGoal, mealType);
        }


        // Hàm tính tỷ lệ khẩu phần ăn từ CaloriesGoal
        private (float mainDish, float sideDish, float soup, float dessert, float snack)
            GetMealRatiosFromCaloriesGoal(float caloriesGoal, MealType mealType)
        {
            return mealType switch
            {
                MealType.Breakfast => (caloriesGoal * 0.60f, caloriesGoal * 0.25f, caloriesGoal * 0.10f, 0f, 0f),
                MealType.Lunch => (caloriesGoal * 0.55f, caloriesGoal * 0.20f, caloriesGoal * 0.15f, caloriesGoal * 0.05f, caloriesGoal * 0.05f),
                MealType.Dinner => (caloriesGoal * 0.50f, caloriesGoal * 0.25f, caloriesGoal * 0.20f, 0f, 0f),
                MealType.Snack => (0f, 0f, 0f, caloriesGoal * 0.50f, caloriesGoal * 0.50f),
                _ => (caloriesGoal * 1f, 0f, 0f, 0f, 0f)
            };
        }







        private async Task<DishDTO?> GetRandomDishWithPortionAsync(
        MealType mealType, DishType dishType, Guid userId,
        MealAllocationDTO allocation, float ratio, DishDTO? mainDish = null)
        {
            _logger.LogInformation($"🔍 Đang tìm món ăn {dishType} cho {mealType} với tỷ lệ {ratio * 100}%...");

            // 🔹 Lấy danh sách món ăn từ FoodFilterService
            var foodItems = await _foodFilterService.GetFilterFoodAsync(
                userId, 1, 100,
                new List<string> { mealType.ToString() },
                new List<string> { dishType.ToString() }
            );

            if (foodItems == null || !foodItems.Items.Any())
            {
                _logger.LogWarning($"⚠️ Không có món ăn nào phù hợp với {mealType} - {dishType}.");
                return null;
            }

            // 🔹 Tính calorie tối đa cho món ăn này
            float maxCalories = allocation.Calories * ratio;

            // 🔹 Chọn món ăn có calorie <= maxCalories
            var selectedFood = foodItems.Items
                .Where(f => f.Calories <= maxCalories)
                .OrderBy(_ => Guid.NewGuid())
                .FirstOrDefault();

            if (selectedFood == null)
            {
                _logger.LogWarning($"⚠️ Không tìm thấy món {dishType} phù hợp trong khoảng {maxCalories} kcal.");
                return null;
            }

            return new DishDTO { Food = ConvertToFoodDTO123(selectedFood) };
        }


        private FoodDTO123? SelectWeightedRandom(List<FoodDTO123> foodList, MealType mealType, DishType dishType, DishDTO? mainDish = null)
        {
            var validFoods = foodList.Where(f => f.FoodType != null).ToList();

            if (dishType == DishType.SideDish && mainDish != null)
            {
                var allowedSideDishes = GetAllowedSideDishTypes(mainDish.Food?.FoodType ?? new List<FoodType>());

                validFoods = validFoods
                    .Where(f => f.FoodType.Any(ft => allowedSideDishes.Contains(ft)))
                    .ToList();
            }

            if (!validFoods.Any())
            {
                _logger.LogWarning($"No suitable {dishType} found for {mealType}.");
                return null;
            }

            return validFoods.OrderBy(_ => Guid.NewGuid()).FirstOrDefault();
        }

        public List<FoodType> GetAllowedSideDishTypes(List<FoodType>? mainDishTypes)
        {
            if (mainDishTypes == null || !mainDishTypes.Any())
            {
                return new List<FoodType> { FoodType.Vegetables };
            }

            var allowedTypes = new HashSet<FoodType>();

            foreach (var type in mainDishTypes)
            {
                var result = type switch
                {
                    FoodType.Carbs => new List<FoodType> { FoodType.Protein, FoodType.Vegetables },
                    FoodType.Protein => new List<FoodType> { FoodType.Vegetables },
                    FoodType.Vegetables => new List<FoodType> { FoodType.Protein, FoodType.Carbs },
                    _ => new List<FoodType> { FoodType.Vegetables }
                };

                allowedTypes.UnionWith(result);
            }

            return allowedTypes.ToList();
        }
        private FoodDTO123 ConvertToFoodDTO123(FoodFilterDTO foodFilterDTO)
        {
            return new FoodDTO123
            {
                FoodId = foodFilterDTO.FoodId,
                FoodName = foodFilterDTO.FoodName,
                FoodType = foodFilterDTO.FoodType,
                Calories = foodFilterDTO.Calories // Nếu có thuộc tính này
            };
        }

    }
}


public class MealPlanWithAllocationDTO
{
    public MealDTO Breakfast { get; set; } = new MealDTO();
    public MealDTO Lunch { get; set; } = new MealDTO();
    public MealDTO Dinner { get; set; } = new MealDTO();
    public MealDTO Snack { get; set; } = new MealDTO();
}

public class MealDTO
{
    public DishDTO MainDish { get; set; } = new DishDTO();
    public DishDTO SideDish { get; set; } = new DishDTO();
    public DishDTO Soup { get; set; } = new DishDTO();
    public DishDTO Dessert { get; set; } = new DishDTO();
    public DishDTO Snack { get; set; } = new DishDTO();
}

public class DishDTO
{
    public FoodDTO123? Food { get; set; }
    public MealAllocationDTO? Allocation { get; set; }
    public MealAllocationDTO? GoalAllocation { get; set; }
    public PortionDTO? Portion { get; set; }
}

public class FoodDTO123
{
    public Guid FoodId { get; set; }
    public string FoodName { get; set; } = string.Empty;
    public List<FoodType> FoodType { get; set; } = [];
    public float Calories { get; set; }
}

// public class PortionDTO
// {
//     public string PortionSize { get; set; } = "";
//     public float PortionWeight { get; set; }
//     public string MeasurementUnit { get; set; } = "g";
// }