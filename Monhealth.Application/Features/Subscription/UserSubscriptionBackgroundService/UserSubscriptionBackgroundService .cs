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
        // Dùng khoảng thời gian 10 giây để test
        private readonly TimeSpan _interval = TimeSpan.FromSeconds(10);

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

                    _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] 🔄 Running background task to check subscriptions...");

                    var userSubscriptions = await userSubscriptionRepository.GetAllAsync();

                    foreach (var subscription in userSubscriptions)
                    {
                        var user = await userRepository.GetUserByIdAsync(subscription.UserId);
                        if (user == null)
                        {
                            _logger.LogWarning($"[{DateTime.Now:HH:mm:ss}] User {subscription.UserId} not found. Skipping...");
                            continue;
                        }

                        // Nếu gói đăng ký đã hết hạn
                        if (subscription.ExpiresAt <= DateTime.Now)
                        {
                            if (subscription.Status != UserSubscriptionStatus.Expired)
                            {
                                subscription.Status = UserSubscriptionStatus.Expired;
                                _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] ⚠️ Subscription expired for User {subscription.UserId}");

                                var userRole = await userRoleRepository.GetUserRoleByUserIdAsync(subscription.UserId);
                                if (userRole != null)
                                {
                                    // Xóa role cũ
                                    userRoleRepository.Remove(userRole);
                                    _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Removed old role for UserId {subscription.UserId}");
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
                                    _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Added 'Member' role for UserId {subscription.UserId}");
                                }
                            }
                            continue; // Bỏ qua user hết hạn
                        }

                        // Chỉ tạo daily meal nếu gói đăng ký còn hiệu lực
                        _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] ✅ Generating daily meal for User {subscription.UserId}");
                        await RecommendMealsForUser(user, dailyMealRepository, mealRepository, mealFoodRepository, foodRepository, portionRepository);

                        await userSubscriptionRepository.SaveChangeAsync();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"[{DateTime.Now:HH:mm:ss}] ❌ Error in background service: {ex.Message}");
                }

                // Log thời gian delay và sau đó delay theo interval (10 giây)
                _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Waiting for next execution in {_interval.TotalSeconds} seconds.");
                await Task.Delay(_interval, stoppingToken);
            }
        }

        /// <summary>
        /// Tạo DailyMeal cho ngày hiện tại nếu chưa tồn tại.
        /// </summary>
        private async Task RecommendMealsForUser(
            AppUser user,
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IFoodRepository foodRepository,
            IPortionRepository portionRepository)
        {
            // Xác định ngày hiện tại
            var currentDate = DateTime.Now.Date;

            // Kiểm tra xem DailyMeal cho user đã tồn tại cho ngày hiện tại chưa
            var existingDailyMeal = await dailyMealRepository.GetDaiLyMealByUser(user.Id, currentDate);
            if (existingDailyMeal != null)
            {
                _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Daily meal for user {user.Id} on {currentDate:yyyy-MM-dd} already exists. Skipping creation.");
                return;
            }
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                _logger.LogError($"User {user.Id} không có mục tiêu (Goal) hợp lệ. Không thể tạo DailyMeal.");
                return; // hoặc throw exception tùy nghiệp vụ
            }
            var dailyMealId = Guid.NewGuid();

            var dailyMeal = new Domain.DailyMeal
            {
                GoalId = userGoal.GoalId,
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
                Meals = new List<Domain.Meal>
                {
                    await CreateMealForType(MealType.Breakfast, user, dailyMealId, currentDate, mealRepository, mealFoodRepository, foodRepository, portionRepository),
                    await CreateMealForType(MealType.Lunch, user, dailyMealId, currentDate, mealRepository, mealFoodRepository, foodRepository, portionRepository),
                    await CreateMealForType(MealType.Dinner, user, dailyMealId, currentDate, mealRepository, mealFoodRepository, foodRepository, portionRepository)
                },
            };

            dailyMealRepository.Add(dailyMeal);
            await dailyMealRepository.SaveChangeAsync();

            _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Daily meal created for user {user.Id} on {currentDate:yyyy-MM-dd}.");
        }

        /// <summary>
        /// Tạo Meal cho từng bữa ăn dựa trên loại bữa, liên kết với DailyMealId và targetDate (ngày của DailyMeal)
        /// </summary>
        private async Task<Domain.Meal> CreateMealForType(
            MealType mealType,
            AppUser user,
            Guid dailyMealId,
            DateTime targetDate,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IFoodRepository foodRepository,
            IPortionRepository portionRepository)
        {
            // Lấy món ăn ngẫu nhiên (giả sử hàm đã được triển khai chính xác)
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await foodRepository.GetRandomProteinAndCarbFood(new List<Guid>());

            // Lấy mục tiêu gần nhất của user
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu cho người dùng.");
            }

            var TotalCarbs = userGoal.CarbsGoal;
            var TotalProteins = userGoal.ProteinGoal;
            var TotalFats = userGoal.FatGoal;
            var totalCaloriesDaily = TotalCarbs * 4 + TotalProteins * 4 + TotalFats * 9;

            float mealCalories = mealType switch
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

            // Tính toán trọng lượng cho rau (lấy ví dụ)
            var vegetableWeight = 100 * vegetableCalories / (vegetableFood?.Nutrition.Calories ?? 1);

            // Tạo các ID cho Portion
            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            Guid vegetablePortionId = Guid.NewGuid();
            Guid balancePortionFoodId = Guid.NewGuid();

            // Tạo danh sách mealFoods
            var mealFoods = new List<Domain.MealFood>();

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
            int targetDateForMeal = targetDate.Date.Day;
            // Kiểm tra xem đã có Meal cho loại mealType và targetDate chưa
            var existingMeal = await mealRepository.GetByUserIdAndMealType(user.Id, mealType, targetDateForMeal);
            Domain.Meal meal;
            if (existingMeal != null)
            {
                _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Updating existing meal for {mealType}...");
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

            // Thêm các Portion tương ứng (ví dụ tính toán đơn giản)
            if (balanceFood != null)
            {
                var proteinWeight = 100 * balanceCalories / (balanceFood.Nutrition.Protein != 0 ? balanceFood.Nutrition.Protein : 1);
                var carbWeight = 100 * balanceCalories / (balanceFood.Nutrition.Carbs != 0 ? balanceFood.Nutrition.Carbs : 1);
                var fatWeight = 100 * balanceCalories / (balanceFood.Nutrition.Fat != 0 ? balanceFood.Nutrition.Fat : 1);
                var balanceWeight = proteinWeight * 4 + carbWeight * 4 + fatWeight * 9;

                portionRepository.Add(new Domain.Portion
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
                portionRepository.Add(new Domain.Portion
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
                var proteinWeight = 100 * proteinCalories / (proteinFood.Nutrition.Calories != 0 ? proteinFood.Nutrition.Calories : 1);
                var carbWeight = 100 * carbsCalories / (carbFood.Nutrition.Calories != 0 ? carbFood.Nutrition.Calories : 1);

                portionRepository.Add(new Domain.Portion
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
                portionRepository.Add(new Domain.Portion
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
                portionRepository.Add(new Domain.Portion
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

            mealRepository.Add(meal);
            return meal;
        }
    }
}
