using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments
{
    public class UpdateStatusPaymentHandler : IRequestHandler<UpdateStatusPaymentQueries, bool>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UpdateStatusPaymentHandler> _logger;

        public UpdateStatusPaymentHandler(IPaymentRepository paymentRepository,
            IPortionRepository portionRepository,
            IFoodRepository foodRepository,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IDailyMealRepository dailyMealRepository,
            IUserRepository userRepository,
            ILogger<UpdateStatusPaymentHandler> logger)
        {
            _paymentRepository = paymentRepository;
            _portionRepository = portionRepository;
            _foodRepository = foodRepository;
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _dailyMealRepository = dailyMealRepository;
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<bool> Handle(UpdateStatusPaymentQueries request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetPayemntByOrderCodeAsync(request.PaymentId);
            if (payment == null)
                throw new BadRequestException($"Không tìm thấy thanh toán : {request.PaymentId}");

            // Cập nhật trạng thái thanh toán
            payment.Status = Core.PaymentStatus.Completed;

            if (payment.Status == Core.PaymentStatus.Completed)
            {
                var gettingUser = await _userRepository.GetUserByIdAsync(payment.UserSubscription.UserId);
                if (payment.UserSubscription == null || payment.UserSubscription.UserId == null)
                {
                    _logger.LogError("UserSubscription hoặc UserId là null. Không thể lấy thông tin người dùng.");
                    throw new BadRequestException("UserSubscription hoặc UserId là null.");
                }

                // Giả sử user được lấy ra từ danh sách UserSubscriptions của gettingUser
                var user = gettingUser.UserSubscriptions
                            .Select(us => us.UserId)
                            .Distinct()
                            .First();

                int daysToCreate = 3; // Số ngày bạn muốn tạo DailyMeal mới
                DateTime startDate = DateTime.Now.Date; // Ngày bắt đầu là hôm nay

                // Với mỗi ngày cần tạo, tìm ngày mà DailyMeal của user chưa tồn tại
                for (int i = 0; i < daysToCreate; i++)
                {
                    DateTime targetDate = startDate.AddDays(i);

                    // Nếu DailyMeal của user đã tồn tại cho targetDate thì tăng ngày cho đến khi tìm được ngày chưa có
                    while (await _dailyMealRepository.GetDaiLyMealByUser(user, targetDate) != null)
                    {
                        targetDate = targetDate.AddDays(1);
                    }

                    // Tạo DailyMeal mới cho ngày targetDate
                    var dailyMealId = Guid.NewGuid();
                    var goal = gettingUser.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();

                    var newDailyMeal = new Domain.DailyMeal
                    {
                        GoalId = goal?.GoalId ?? Guid.Empty,
                        DailyMealId = dailyMealId,
                        UserId = user,
                        CreatedAt = targetDate,
                        UpdatedAt = targetDate,
                        TotalCalories = 0,
                        TotalProteins = 0,
                        TotalCarbs = 0,
                        TotalFats = 0,
                        TotalFibers = 0,
                        TotalSugars = 0,
                        Meals = new List<Domain.Meal>()
                    };

                    // Tạo các Meal (Breakfast, Lunch, Dinner) cho DailyMeal mới
                    var breakfast = await CreateMealForType(MealType.Breakfast, gettingUser, dailyMealId, targetDate);
                    var lunch = await CreateMealForType(MealType.Lunch, gettingUser, dailyMealId, targetDate);
                    var dinner = await CreateMealForType(MealType.Dinner, gettingUser, dailyMealId, targetDate);

                    newDailyMeal.Meals.Add(breakfast);
                    newDailyMeal.Meals.Add(lunch);
                    newDailyMeal.Meals.Add(dinner);

                    // Thêm DailyMeal vào repository
                    _dailyMealRepository.Add(newDailyMeal);
                }
            }

            await _paymentRepository.SaveChangeAsync();
            return true;
        }

        /// <summary>
        /// Tạo Meal cho từng bữa ăn dựa trên loại bữa, liên kết với DailyMealId và targetDate xác định.
        /// </summary>
        private async Task<Domain.Meal> CreateMealForType(MealType mealType, AppUser user, Guid dailyMealId, DateTime targetDate)
        {
            // Lấy các thực phẩm ngẫu nhiên theo logic của bạn
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await _foodRepository.GetRandomProteinAndCarbFood(new List<Guid>());

            // Lấy mục tiêu gần nhất của người dùng
            var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
            if (userGoal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu cho người dùng.");
            }
            var TotalCarbs = userGoal.CarbsGoal;
            var TotalProteins = userGoal.ProteinGoal;
            var TotalFats = userGoal.FatGoal;

            var totalCaloriesDaily = TotalCarbs * 4 + TotalProteins * 4 + TotalFats * 9;
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

            // Tính trọng lượng khẩu phần cho rau dựa trên lượng calo và giá trị dinh dưỡng
            var vegetableWeight = 100 * vegetableCalories / vegetableFood!.Nutrition.Calories;
            vegetableWeight = RoundPortionWeight((float)vegetableWeight, userGoal.GoalType);

            Guid proteinPortionId = Guid.NewGuid();
            Guid carbPortionId = Guid.NewGuid();
            Guid vegetablePortionId = Guid.NewGuid();
            Guid balancePortionFoodId = Guid.NewGuid();

            var mealFoods = new List<Domain.MealFood>();

            // Nếu balanceFood tồn tại, sử dụng balanceFood và vegetableFood
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

            // Tạo Meal mới, liên kết với DailyMealId và targetDate (ngày của DailyMeal)
            Domain.Meal meal = new Domain.Meal
            {
                MealType = mealType,
                UserId = user.Id,
                DailyMealId = dailyMealId,
                CreatedAt = targetDate,
                UpdatedAt = DateTime.Now,
                MealFoods = mealFoods,
            };

            // Thêm các Portion tương ứng cho các món ăn
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

            // Thêm Meal vào repository
            _mealRepository.Add(meal);

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
