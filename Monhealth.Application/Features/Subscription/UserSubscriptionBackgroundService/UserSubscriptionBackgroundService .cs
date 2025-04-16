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
        // Dùng khoảng thời gian 2 phút để test
        private readonly TimeSpan _interval = TimeSpan.FromMinutes(2);
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
                    var metricRepository = scope.ServiceProvider.GetRequiredService<IMetricRepository>();

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
                                    userRoleRepository.Remove(userRole);
                                    _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Removed old role for UserId {subscription.UserId}");
                                }

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

                        DateTime today = DateTime.Now.Date;

                        // ===== NEW CONDITION =====
                        // DailyMeal generation should only start from subscription.StartTime + 7 days.
                        // (Assumes a StartTime property exists in the subscription)
                        DateTime generationStartDate = subscription.StartedAt.AddDays(7).Date;
                        if (today < generationStartDate)
                        {
                            _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Daily meal generation postponed for User {subscription.UserId} until {generationStartDate:yyyy-MM-dd}.");
                            continue;
                        }
                        // ==========================

                        // Tạo DailyMeal cho 7 ngày liên tiếp (bao gồm hôm nay)
                        for (int i = 0; i < 7; i++)
                        {
                            DateTime targetDate = today.AddDays(i);
                            var existingDailyMeal = await dailyMealRepository.GetDaiLyMealByUser(user.Id, targetDate);
                            if (existingDailyMeal != null)
                            {
                                continue;
                            }

                            await RecommendMealsForUserForDate(user, targetDate, dailyMealRepository, mealRepository, mealFoodRepository, foodRepository, portionRepository);
                        }

                        await userSubscriptionRepository.SaveChangeAsync();
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"[{DateTime.Now:HH:mm:ss}] ❌ Error in background service: {ex.Message}");
                }

                await Task.Delay(_interval, stoppingToken);
            }
        }


        /// <summary>
        /// Tạo DailyMeal cho một ngày nhất định (targetDate) nếu chưa tồn tại.
        /// </summary>
        private async Task RecommendMealsForUserForDate(
            AppUser user,
            DateTime targetDate,
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IFoodRepository foodRepository,
            IPortionRepository portionRepository)
        {
            var existingDailyMeal = await dailyMealRepository.GetDaiLyMealByUser(user.Id, targetDate);
            if (existingDailyMeal != null)
            {
                // _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Daily meal for user {user.Id} on {targetDate:yyyy-MM-dd} already exists. Skipping creation.");
                return;
            }

            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                _logger.LogError($"User {user.Id} không có mục tiêu (Goal) hợp lệ. Không thể tạo DailyMeal.");
                return;
            }
            var dailyMealId = Guid.NewGuid();

            var dailyMeal = new Domain.DailyMeal
            {
                GoalId = userGoal.GoalId,
                DailyMealId = dailyMealId,
                UserId = user.Id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                TotalCalories = 0,
                TotalProteins = 0,
                TotalCarbs = 0,
                TotalFats = 0,
                TotalFibers = 0,
                TotalSugars = 0,
                Meals = new List<Domain.Meal>
                {
                    await CreateMealForType(MealType.Breakfast, user, dailyMealId, targetDate, mealRepository, mealFoodRepository, foodRepository, portionRepository),
                    await CreateMealForType(MealType.Lunch, user, dailyMealId, targetDate, mealRepository, mealFoodRepository, foodRepository, portionRepository),
                    await CreateMealForType(MealType.Dinner, user, dailyMealId, targetDate, mealRepository, mealFoodRepository, foodRepository, portionRepository)
                },
            };

            dailyMealRepository.Add(dailyMeal);
            await dailyMealRepository.SaveChangeAsync();

            // _logger.LogInformation($"[{DateTime.Now:HH:mm:ss}] Daily meal created for user {user.Id} on {targetDate:yyyy-MM-dd}.");
        }

        /// <summary>
        /// Tạo Meal cho từng bữa ăn dựa trên loại bữa, liên kết với DailyMealId và targetDate.
        /// Công thức tính toán calories và trọng lượng khẩu phần đã được tích hợp.
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
            // Lấy các thực phẩm ngẫu nhiên theo logic của bạn
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await foodRepository.GetRandomProteinAndCarbFood(new List<Guid>());
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
                throw new Exception("Không tìm thấy mục tiêu cho người dùng.");

            // Lấy mục tiêu về macro
            var TotalCarbs = userGoal.CarbsGoal;
            var TotalProteins = userGoal.ProteinGoal;
            var TotalFats = userGoal.FatGoal;
            var totalCaloriesDaily = TotalCarbs * 4 + TotalProteins * 4 + TotalFats * 9;

            // Tính toán calories của bữa ăn dựa trên loại meal và GoalType
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

            // Tính trọng lượng khẩu phần cho rau dựa trên calories
            var vegetableWeight = 100 * vegetableCalories / (vegetableFood!.Nutrition.Calories != 0 ? vegetableFood.Nutrition.Calories : 1);
            vegetableWeight = RoundPortionWeight((float)vegetableWeight, userGoal.GoalType);

            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            Guid vegetablePortionId = Guid.NewGuid();
            Guid balancePortionFoodId = Guid.NewGuid();

            var mealFoods = new List<Domain.MealFood>();

            if (balanceFood != null)
            {
                // Sử dụng balanceFood và vegetableFood nếu có
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = balanceFood.FoodId,
                    PortionId = balancePortionFoodId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }
            else if (proteinFood != null && carbFood != null && vegetableFood != null)
            {
                // Nếu balanceFood không có, sử dụng proteinFood, carbFood và vegetableFood
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = proteinFood.FoodId,
                    PortionId = proteinPortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = carbFood.FoodId,
                    PortionId = carbPortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
            }
            else
            {
                _logger.LogError("Không tìm thấy thức ăn phù hợp.");
            }

            // Tạo Meal mới, liên kết với DailyMealId và targetDate
            Domain.Meal meal = new Domain.Meal
            {
                MealType = mealType,
                UserId = user.Id,
                DailyMealId = dailyMealId,
                CreatedAt = DateTime.Now,
                MealDate = targetDate,
                UpdatedAt = DateTime.Now,
                MealFoods = mealFoods,
            };

            // Thêm các Portion tương ứng
            if (balanceFood != null)
            {
                var balanceWeight = 100 * balanceCalories / (balanceFood.Nutrition.Calories != 0 ? balanceFood.Nutrition.Calories : 1);
                balanceWeight = RoundPortionWeight((float)balanceWeight, userGoal.GoalType);

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
                proteinWeight = RoundPortionWeight((float)proteinWeight, userGoal.GoalType);
                carbWeight = RoundPortionWeight((float)carbWeight, userGoal.GoalType);

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

        private float RoundPortionWeight(float portionWeight, GoalType goalType)
        {
            return goalType switch
            {
                GoalType.WeightLoss => (float)Math.Floor(portionWeight),
                GoalType.WeightGain => (float)Math.Ceiling(portionWeight),
                GoalType.Maintenance => (float)Math.Round(portionWeight),
                _ => portionWeight,
            };
        }
    }
}
