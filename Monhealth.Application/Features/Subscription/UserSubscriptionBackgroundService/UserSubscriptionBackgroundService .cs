using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Subscription.UserSubscriptionBackgroundService
{
    public class UserSubscriptionBackgroundService : BackgroundService
    {
        private readonly ILogger<UserSubscriptionBackgroundService> _logger;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly TimeSpan _interval = TimeSpan.FromDays(3); // Chạy mỗi 3 ngày
        public UserSubscriptionBackgroundService(IServiceScopeFactory serviceScopeFactory, ILogger<UserSubscriptionBackgroundService> logger)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _serviceScopeFactory.CreateScope();
                    var userSubscriptionRepository = scope.ServiceProvider.GetRequiredService<IUserSubscriptionRepository>();
                    var dailyMealRepository = scope.ServiceProvider.GetRequiredService<IDailyMealRepository>();
                    var mealRepository = scope.ServiceProvider.GetRequiredService<IMealRepository>();
                    var mealFoodRepository = scope.ServiceProvider.GetRequiredService<IMealFoodRepository>();
                    var foodRepository = scope.ServiceProvider.GetRequiredService<IFoodRepository>();
                    var portionRepository = scope.ServiceProvider.GetRequiredService<IPortionRepository>();
                    var userRepository = scope.ServiceProvider.GetRequiredService<IUserRepository>();
                    var userRoleRepository = scope.ServiceProvider.GetRequiredService<IUserRoleRepository>();

                    _logger.LogInformation("🔄 Running background task to check subscriptions...");

                    var userSubscriptions = await userSubscriptionRepository.GetAllAsync();

                    foreach (var subscription in userSubscriptions)
                    {
                        var user = await userRepository.GetUserByIdAsync(subscription.UserId);
                        if (user == null)
                        {
                            _logger.LogWarning($"User {subscription.UserId} not found. Skipping...");
                            continue;
                        }



                        // 🔍 Kiểm tra nếu Subscription đã hết hạn
                        if (subscription.ExpiresAt <= DateTime.Now)
                        {
                            if (subscription.Status != UserSubscriptionStatus.Expired)
                            {
                                subscription.Status = UserSubscriptionStatus.Expired;
                                _logger.LogInformation($"⚠️ Subscription expired for User {subscription.UserId}");

                                var userRole = await userRoleRepository.GetUserRoleByUserIdAsync(subscription.UserId);
                                if (userRole != null)
                                {
                                    // Xóa role cũ
                                     userRoleRepository.Remove(userRole);
                                    _logger.LogInformation($"Removed old role for UserId {subscription.UserId}");
                                }

                                // Thêm role "Member" cho user
                                var memberRole = await userRoleRepository.GetRoleByNameAsync("Member");
                                if (memberRole != null)
                                {
                                    var newUserRole = new IdentityUserRole<Guid>
                                    {
                                        UserId = subscription.UserId,
                                        RoleId = memberRole.Id
                                    };
                                     userRoleRepository.Add(newUserRole);
                                    _logger.LogInformation($"Added 'Member' role for UserId {subscription.UserId}");
                                }

                                continue;
                            }

                            _logger.LogInformation($"✅ Generating meal recommendations for User {subscription.UserId}");
                            await RecommendMealsForUser(user, dailyMealRepository, mealRepository, mealFoodRepository, foodRepository, portionRepository);
                        }

                        await userSubscriptionRepository.SaveChangeAsync();
                        _logger.LogInformation("✅ Background task completed.");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"❌ Error in background service: {ex.Message}");
                }

                await Task.Delay(_interval, stoppingToken);
            }
        }

        private async Task RecommendMealsForUser(
            AppUser user,
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IFoodRepository foodRepository,
            IPortionRepository portionRepository)
        {
            int days = 3;
            for (int i = 0; i < days; i++)
            {
                var currentDate = DateTime.Now.Date.AddDays(i);
                var dailyMealId = Guid.NewGuid();

                var dailyMeal = new Domain.DailyMeal
                {
                    DailyMealId = dailyMealId,
                    UserId = user.Id,
                    CreatedAt = currentDate,
                    UpdatedAt = currentDate,
                    TotalCalories = 0,
                    TotalProteins = 0,
                    TotalCarbs = 0,
                    TotalFats = 0,
                    TotalFibers = 0,
                    TotalSugars = 0,
                    Meals = [
                    await CreateMealForType(MealType.Breakfast, user, dailyMealId, mealRepository, mealFoodRepository, foodRepository, portionRepository),
                    await CreateMealForType(MealType.Lunch, user, dailyMealId, mealRepository, mealFoodRepository, foodRepository, portionRepository),
                    await CreateMealForType(MealType.Dinner, user, dailyMealId, mealRepository, mealFoodRepository, foodRepository, portionRepository)
                    ],
                };

                dailyMealRepository.Add(dailyMeal);
                await dailyMealRepository.SaveChangeAsync();
            }
        }

        private async Task<Domain.Meal> CreateMealForType(MealType mealType, AppUser user, Guid dailyMealId,
            IMealRepository _mealRepository, IMealFoodRepository _mealFoodRepository, IFoodRepository _foodRepository, IPortionRepository _portionRepository)
        {
            // Get Random First
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await _foodRepository.GetRandomProteinAndCarbFood([]);


            // Lấy mục tiêu gần nhất (mới nhất) của người dùng
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu cho người dùng.");
            }

            var totalCaloriesDaily = userGoal.CaloriesGoal; // Lấy CaloriesGoal từ userGoal nếu tồn tại
            var mealCalories = mealType switch
            {
                MealType.Breakfast => userGoal.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.20f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.25f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.30f,
                    _ => 0
                },
                MealType.Lunch => userGoal.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.40f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.35f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.35f,
                    _ => 0
                },
                MealType.Dinner => userGoal.GoalType switch
                {
                    GoalType.WeightLoss => totalCaloriesDaily * 0.30f,
                    GoalType.WeightGain => totalCaloriesDaily * 0.30f,
                    GoalType.Maintenance => totalCaloriesDaily * 0.25f,
                    _ => 0
                },
                _ => 0
            };
            double proteinCalories = 0;
            double carbsCalories = 0;
            double vegetableCalories = 0;
            double balanceCalories = 0;
            if (mealCalories > 0)
            {

                if (userGoal.GoalType == GoalType.WeightLoss)
                {
                    proteinCalories = mealCalories * 0.4;
                    carbsCalories = mealCalories * 0.5;
                    vegetableCalories = mealCalories * 0.1;
                    balanceCalories = mealCalories * 0.9;
                }
                else if (userGoal.GoalType == GoalType.WeightGain)
                {
                    proteinCalories = mealCalories * 0.5;
                    carbsCalories = mealCalories * 0.4;
                    vegetableCalories = mealCalories * 0.1;
                    balanceCalories = mealCalories * 0.9;
                }
                else if (userGoal.GoalType == GoalType.Maintenance)
                {
                    proteinCalories = mealCalories * 0.45;
                    carbsCalories = mealCalories * 0.45;
                    vegetableCalories = mealCalories * 0.1;
                    balanceCalories = mealCalories * 0.9;
                }
            }
            // Phân bổ calo cho protein, carbs và rau
            var vegetableWeight = 100 * vegetableCalories / vegetableFood!.Nutrition.Calories;

            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            Guid vegetablePortionId = Guid.NewGuid();
            Guid balancePortionFoodId = Guid.NewGuid();

            Domain.Meal meal = new Domain.Meal();
            var mealFoods = new List<Domain.MealFood>();
            foreach (var item in mealFoods)
            {

                var existingMealItem = await _mealFoodRepository.GetByMealIdAndFoodId(meal.MealId, item.FoodId);
                if (existingMealItem != null)
                {
                    existingMealItem.Quantity += item.Quantity;
                    existingMealItem.UpdatedAt = DateTime.Now;
                }
            }
            if (balanceFood != null)
            {
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = balanceFood.FoodId,
                    Quantity = 1,
                    IsCompleted = false,
                    PortionId = balancePortionFoodId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }
            else
            {
                // Nếu balanceFood không tồn tại, thêm proteinFood, carbFood và vegetableFood vào mealFoods
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = proteinFood.FoodId,
                    PortionId = proteinPortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = carbFood.FoodId,
                    PortionId = carbPortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }
            var currentDate = DateTime.Now.Date.Day;
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(user.Id, mealType, currentDate);
            if (existingMeal != null)
            {

                Console.WriteLine("Updating existing meal...");
                meal = existingMeal;
                meal.UpdatedAt = DateTime.Now;
            }
            else
            {

                meal = new Domain.Meal
                {
                    MealType = mealType,
                    UserId = user.Id,
                    DailyMealId = dailyMealId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MealFoods = mealFoods,
                };

            }

            // Thêm các Portion cho Balance, Protein, Carb và Vegetable
            if (balanceFood != null)
            {
                var balanceWeight = 100 * balanceCalories / balanceFood.Nutrition.Calories;

                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = balancePortionFoodId,
                    PortionSize = "phần",
                    PortionWeight = (float)balanceWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });

                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = vegetablePortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
            }
            else
            {
                var proteinWeight = 100 * proteinCalories / proteinFood.Nutrition.Calories;
                var carbWeight = 100 * carbsCalories / carbFood.Nutrition.Calories;

                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = proteinPortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)proteinWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });

                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = carbPortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)carbWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });

                _portionRepository.Add(new Domain.Portion
                {

                    PortionId = vegetablePortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });
            }

            // Lưu meal vào repository
            _mealRepository.Add(meal);
            return meal;
        }
    }
}