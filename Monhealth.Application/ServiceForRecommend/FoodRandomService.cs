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

            // 🔹 Lấy tỷ lệ các thành phần món ăn dựa trên GoalType của user
            var (mainDishRatio, sideDishRatio, soupRatio, dessertRatio, snackRatio) =
                await GetMealRatiosAsync(userId, mealType, activityLevel);

            // 🔹 Lấy món chính
            var mainDish = await GetRandomDishWithPortionAsync(mealType, DishType.MainDish, userId, allocation, mainDishRatio);
            if (mainDish == null)
            {
                _logger.LogWarning($"⚠️ Không tìm thấy món chính cho {mealType}.");
            }

            // 🔹 Lấy món phụ nếu có
            DishDTO? sideDish = null;
            if (sideDishRatio > 0)
            {
                sideDish = await GetRandomDishWithPortionAsync(mealType, DishType.SideDish, userId, allocation, sideDishRatio, mainDish);
            }

            // 🔹 Lấy soup nếu có
            DishDTO? soup = null;
            if (soupRatio > 0)
            {
                soup = await GetRandomDishWithPortionAsync(mealType, DishType.Soup, userId, allocation, soupRatio);
            }

            // 🔹 Lấy món tráng miệng nếu có
            DishDTO? dessert = null;
            if (dessertRatio > 0)
            {
                dessert = await GetRandomDishWithPortionAsync(mealType, DishType.Dessert, userId, allocation, dessertRatio);
            }

            // 🔹 Lấy snack nếu có
            DishDTO? snack = null;
            if (snackRatio > 0)
            {
                snack = await GetRandomDishWithPortionAsync(mealType, DishType.Snack, userId, allocation, snackRatio);
            }

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
            // 🔹 Lấy GoalType từ Database để xác định loại chế độ ăn
            var goalType = await _goalService.GetGoalTypeByUserIdAsync(userId);

            if (goalType == null)
            {
                throw new Exception($"❌ Không tìm thấy GoalType cho user {userId}");
            }

            // 🔹 Phân bổ tỷ lệ khẩu phần ăn theo từng GoalType
            return mealType switch
            {
                MealType.Breakfast => goalType switch
                {
                    GoalType.WeightLoss => (0.70f, 0.20f, 0.10f, 0f, 0f),  // 70% Main, 20% Side, 10% Soup
                    GoalType.Maintenance => (0.60f, 0.25f, 0.15f, 0f, 0f), // 60% Main, 25% Side, 15% Soup
                    GoalType.WeightGain => (0.75f, 0.15f, 0.10f, 0f, 0f),  // 75% Main, 15% Side, 10% Soup
                    _ => (1f, 0f, 0f, 0f, 0f)
                },

                MealType.Lunch => goalType switch
                {
                    GoalType.WeightLoss => (0.60f, 0.25f, 0.10f, 0.05f, 0f),  // 60% Main, 25% Side, 10% Soup, 5% Dessert
                    GoalType.Maintenance => (0.55f, 0.20f, 0.15f, 0.05f, 0.05f), // 55% Main, 20% Side, 15% Soup, 5% Dessert, 5% Snack
                    GoalType.WeightGain => (0.65f, 0.20f, 0.10f, 0f, 0.05f),  // 65% Main, 20% Side, 10% Soup, 5% Snack
                    _ => (0.55f, 0.3f, 0.1f, 0.05f, 0f)
                },

                MealType.Dinner => goalType switch
                {
                    GoalType.WeightLoss => (0.50f, 0.30f, 0.20f, 0f, 0f),  // 50% Main, 30% Side, 20% Soup
                    GoalType.Maintenance => (0.50f, 0.25f, 0.15f, 0f, 0.05f), // 50% Main, 25% Side, 15% Soup, 5% Snack
                    GoalType.WeightGain => (0.50f, 0.30f, 0.20f, 0f, 0f),  // 50% Main, 30% Side, 20% Soup
                    _ => (0.6f, 0.3f, 0.1f, 0f, 0f)
                },

                MealType.Snack => goalType switch
                {
                    GoalType.WeightLoss => (0f, 0f, 0f, 0f, 1.0f),  // 100% Snack
                    GoalType.Maintenance => (0f, 0f, 0f, 0.50f, 0.50f), // 50% Dessert, 50% Snack
                    GoalType.WeightGain => (0f, 0f, 0f, 0f, 1.0f),  // 100% Snack
                    _ => (0.8f, 0.2f, 0f, 0f, 0f)
                },

                _ => (1f, 0f, 0f, 0f, 0f) // Mặc định nếu MealType không hợp lệ
            };
        }



        private async Task<DishDTO?> GetRandomDishWithPortionAsync(
            MealType mealType, DishType dishType, Guid userId,
            MealAllocationDTO allocation, float ratio, DishDTO? mainDish = null)
        {
            _logger.LogInformation($"🔍 Đang tìm món ăn {dishType} cho {mealType}...");

            var mealTypeList = new List<MealType> { MealType.Breakfast, MealType.Lunch, MealType.Dinner, MealType.Snack };
            var dishTypeList = new List<DishType> { DishType.MainDish, DishType.SideDish, DishType.Soup, DishType.Dessert, DishType.Drink };

            // ✅ Chuyển `List<MealType>` thành `List<string>`
            var mealTypeStringList = mealTypeList.Select(mt => mt.ToString()).ToList();
            var dishTypeStringList = dishTypeList.Select(dt => dt.ToString()).ToList();

            var filteredFoods = await _foodFilterService.GetFilterFoodAsync(
                userId, 1, 100,
                mealTypeStringList,  // ✅ Đã chuyển thành `List<string>`
                dishTypeStringList   // ✅ Đã chuyển thành `List<string>`
            );

            if (filteredFoods == null || !filteredFoods.Items.Any())
            {
                _logger.LogWarning($"⚠️ Không có món ăn nào phù hợp với {mealType} - {dishType}.");
                return null;
            }

            _logger.LogInformation($"✅ Số món ăn phù hợp: {filteredFoods.Items.Count()}");

            var foodList = filteredFoods.Items.Select(f => new FoodDTO123
            {
                FoodId = f.FoodId,
                FoodName = f.FoodName,
                FoodType = f.FoodType
            }).ToList();

            var selectedFood = SelectWeightedRandom(foodList, mealType, dishType, mainDish);
            if (selectedFood == null)
            {
                _logger.LogWarning($"⚠️ Không tìm thấy món {dishType} phù hợp cho {mealType}.");
                return null;
            }

            return new DishDTO { Food = selectedFood };
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
}

// public class PortionDTO
// {
//     public string PortionSize { get; set; } = "";
//     public float PortionWeight { get; set; }
//     public string MeasurementUnit { get; set; } = "g";
// }