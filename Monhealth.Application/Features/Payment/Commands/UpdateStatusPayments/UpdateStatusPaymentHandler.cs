using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments
{
    public class UpdateStatusPaymentHandler(
    IPaymentRepository paymentRepository,
    IPortionRepository _portionRepository,
    IFoodRepository _foodRepository,
    IMealRepository _mealRepository,
    IMealFoodRepository _mealFoodRepository,
    IDailyMealRepository _dailyMealRepository,
    IUserRepository _userRepository,
    ILogger<UpdateStatusPaymentHandler> _logger) :
    IRequestHandler<UpdateStatusPaymentQueries, bool>
    {
        public async Task<bool> Handle(UpdateStatusPaymentQueries request, CancellationToken cancellationToken)
        {
            var payment = await paymentRepository.GetPayemntByOrderCodeAsync(request.PaymentId);
            if (payment == null) throw new BadRequestException($"Không tìm thấy thanh toán :{request.PaymentId}");
            payment.Status = Core.PaymentStatus.Completed;
            if (payment.Status == Core.PaymentStatus.Completed)
            {
                var gettingUser = await _userRepository.GetUserByIdAsync(payment.UserSubscription.UserId);
                if (payment.UserSubscription == null || payment.UserSubscription.UserId == null)
                {
                    _logger.LogError("UserSubscription hoặc UserId là null. Không thể lấy thông tin người dùng.");
                    throw new BadRequestException("UserSubscription hoặc UserId là null.");
                }

                var user = gettingUser.UserSubscriptions.
                        Select(us => us.UserId).Distinct().First();

                int days = 3;
                // Biến để lưu currentDate
                DateTime? storedCurrentDate = null;

                int currentDay = DateTime.Now.Date.Day;
                // Thêm DailyMeal cho mỗi ngày và gán currentDate vào Meal
                for (int i = 0; i < days; i++)
                {
                    var dailyMealId = Guid.NewGuid();

                    // Tính toán ngày tiếp theo để kiểm tra xem DailyMeal có tồn tại cho ngày đó không
                    var currentDate = DateTime.Now.Date.AddDays(i);

                    // Kiểm tra xem DailyMeal đã tồn tại cho ngày hiện tại chưa
                    var checkDailyMeal = await _dailyMealRepository.GetDaiLyMealByUser(user, currentDate);

                    // Nếu DailyMeal đã tồn tại cho ngày này, tăng thêm một ngày
                    if (checkDailyMeal != null)
                    {
                        // Tăng ngày lên một ngày để bắt đầu từ ngày hôm sau
                        currentDate = currentDate.AddDays(1);
                    }

                    // Tạo DailyMeal mới cho ngày (hoặc ngày tiếp theo nếu đã tồn tại)
                    _dailyMealRepository.Add(new Domain.DailyMeal
                    {
                        GoalId = gettingUser.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault()?.GoalId ?? Guid.Empty,
                        DailyMealId = dailyMealId,
                        UserId = user,
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
            await CreateMealForType(MealType.Breakfast, gettingUser, dailyMealId), // Breakfast
            await CreateMealForType(MealType.Lunch, gettingUser, dailyMealId), // Lunch
            await CreateMealForType(MealType.Dinner, gettingUser, dailyMealId), // Dinner
        },
                    });
                }



            }
            await paymentRepository.SaveChangeAsync();
            return true;
        }
        private async Task<Domain.Meal> CreateMealForType(MealType mealType, AppUser user, Guid dailyMealId)
        {
            // Get Random First
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await _foodRepository.GetRandomProteinAndCarbFood([]);


            // Lấy mục tiêu gần nhất (mới nhất) của người dùng
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu cho người dùng.");
            }
            var TotalCarbs = userGoal.CarbsGoal;
            var TotalProteins = userGoal.ProteinGoal;
            var TotalFats = userGoal.FatGoal;

            var totalCaloriesDaily = TotalCarbs * 4 + TotalProteins * 4 + TotalFats * 9; // Lấy CaloriesGoal từ userGoal nếu tồn tại
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
            vegetableWeight = RoundPortionWeight((float)vegetableWeight, userGoal.GoalType);
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
                // Nếu balanceFood không tồn tại, thêm proteinFood, carbFood và vegetableFood vào mealFoods
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
                return meal;
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
                balanceWeight = RoundPortionWeight((float)balanceWeight, userGoal.GoalType);

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
                proteinWeight = RoundPortionWeight((float)proteinWeight, userGoal.GoalType);
                carbWeight = RoundPortionWeight((float)carbWeight, userGoal.GoalType);


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
        private float RoundPortionWeight(float portionWeight, GoalType goalType)
        {
            switch (goalType)
            {
                case GoalType.WeightLoss:
                    // Giảm cân: Làm tròn xuống
                    return (float)Math.Floor(portionWeight);
                case GoalType.WeightGain:
                    // Tăng cân: Làm tròn lên
                    return (float)Math.Ceiling(portionWeight);
                case GoalType.Maintenance:
                    // Duy trì: Làm tròn đến số nguyên gần nhất
                    return (float)Math.Round(portionWeight);
                default:
                    // Nếu không có mục tiêu, giữ nguyên giá trị
                    return portionWeight;
            }
        }

    }
}
