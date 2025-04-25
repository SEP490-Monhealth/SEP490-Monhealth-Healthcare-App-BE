using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricCommandHandler : IRequestHandler<UpdateMetricCommand, bool>
    {
        private readonly IMetricsCalculator _metricCalculator;
        private readonly IGoalsCalculator _goalsCalculator;
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateMetricCommandHandler> _logger;

        // Các repository liên quan đến DailyMeal & Meal
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IUserRepository _userRepository;

        public UpdateMetricCommandHandler(
            IMetricRepository metricRepository,
            IMapper mapper,
            IMetricsCalculator metricCalculator,
            IGoalsCalculator goalsCalculator,
            IGoalRepository goalRepository,
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IFoodRepository foodRepository,
            IPortionRepository portionRepository,
            IUserRepository userRepository,
            ILogger<UpdateMetricCommandHandler> logger)
        {
            _metricCalculator = metricCalculator;
            _goalsCalculator = goalsCalculator;
            _metricRepository = metricRepository;
            _goalRepository = goalRepository;
            _mapper = mapper;
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _foodRepository = foodRepository;
            _portionRepository = portionRepository;
            _userRepository = userRepository;
            _logger = logger;
        }

        public async Task<bool> Handle(UpdateMetricCommand request, CancellationToken cancellationToken)
        {
            // --- Cập nhật Metric ---
            var metricToUpdate = await _metricRepository.GetByIdAsync(request.MetricId);
            if (metricToUpdate == null)
            {
                return false;
            }

            // Tính tuổi từ DateOfBirth
            var age = DateTime.UtcNow.Year - request.UpdateMetricDTO.DateOfBirth.Year;
            if (DateTime.UtcNow.DayOfYear < request.UpdateMetricDTO.DateOfBirth.DayOfYear)
            {
                age--;
            }

            bool isUpdated = false;

            if (request.UpdateMetricDTO.Height != metricToUpdate.Height || request.UpdateMetricDTO.Weight != metricToUpdate.Weight)
            {
                metricToUpdate.Bmi = (float)_metricCalculator.CalculateBMI(request.UpdateMetricDTO.Weight, request.UpdateMetricDTO.Height);
                isUpdated = true;
            }

            if (request.UpdateMetricDTO.Height != metricToUpdate.Height ||
                request.UpdateMetricDTO.Weight != metricToUpdate.Weight ||
                request.UpdateMetricDTO.DateOfBirth != metricToUpdate.DateOfBirth ||
                !string.Equals(request.UpdateMetricDTO.Gender.ToString(), metricToUpdate.Gender.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                metricToUpdate.Bmr = _metricCalculator.CalculateBMR(request.UpdateMetricDTO.Weight, request.UpdateMetricDTO.Height, age, request.UpdateMetricDTO.Gender.ToString());
                isUpdated = true;
            }

            if (request.UpdateMetricDTO.ActivityLevel != metricToUpdate.ActivityLevel || isUpdated)
            {
                metricToUpdate.Tdee = _metricCalculator.CalculateTDEE(metricToUpdate.Bmr, request.UpdateMetricDTO.ActivityLevel);
                isUpdated = true;
            }

            if (request.UpdateMetricDTO.Height != metricToUpdate.Height ||
                !string.Equals(request.UpdateMetricDTO.Gender.ToString(), metricToUpdate.Gender.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                metricToUpdate.Ibw = _metricCalculator.CalculateIBW(request.UpdateMetricDTO.Height, request.UpdateMetricDTO.Gender.ToString());
                isUpdated = true;
            }

            if (isUpdated)
            {
                metricToUpdate.UpdatedAt = DateTime.UtcNow;
                _mapper.Map(request.UpdateMetricDTO, metricToUpdate);
                _metricRepository.Update(metricToUpdate);
                await _metricRepository.SaveChangeAsync();
            }

            // --- Cập nhật Goal ---
            var goalToUpdate = await _goalRepository.GetGoalByUser(metricToUpdate.UserId);
            if (goalToUpdate == null)
            {
                throw new Exception("Không tìm thấy mục tiêu");
            }
            goalToUpdate.UpdatedAt = DateTime.UtcNow;
            _goalsCalculator.UpdateMetricCalculateGoal(goalToUpdate, goalToUpdate.GoalType.ToString(), metricToUpdate.Tdee, metricToUpdate.Weight, metricToUpdate.ActivityLevel);
            _goalRepository.Update(goalToUpdate);
            await _goalRepository.SaveChangeAsync();
            // ------------------------

            // --- Cập nhật DailyMeal: Xóa và tạo lại các DailyMeal (và các Meal liên quan) sau ngày hiện tại ---
            var today = DateTime.Today;

            // Lấy danh sách các DailyMeal của user có CreatedAt sau ngày hiện tại
            var dailyMealsToRecreate = await _dailyMealRepository.GetDailyMealsAfterDate(metricToUpdate.UserId, today);

            if (dailyMealsToRecreate != null && dailyMealsToRecreate.Any())
            {
                // Lưu lại danh sách các ngày cần tạo lại (lấy phần Date để đảm bảo khớp)
                var datesToRecreate = dailyMealsToRecreate.Select(dm => dm.CreatedAt.HasValue ? dm.CreatedAt.Value.Date : DateTime.MinValue).ToList();

                // Xóa các DailyMeal và các Meal liên quan
                foreach (var dailyMeal in dailyMealsToRecreate)
                {
                    if (dailyMeal.Meals != null && dailyMeal.Meals.Any())
                    {
                        foreach (var meal in dailyMeal.Meals.ToList())
                        {
                            _mealRepository.Remove(meal);
                        }
                        dailyMeal.Meals.Clear();
                        await _mealRepository.SaveChangeAsync();
                    }
                    _dailyMealRepository.Remove(dailyMeal);
                    await _dailyMealRepository.SaveChangeAsync();
                }

                // Lấy lại thông tin user để đảm bảo mục tiêu mới nhất được lấy ra
                var user = await _userRepository.GetUserByIdAsync(metricToUpdate.UserId);
                if (user == null)
                {
                    throw new Exception("Không tìm thấy người dùng.");
                }

                // Tạo lại DailyMeal và các Meal cho đúng các ngày đã xóa
                foreach (var targetDate in datesToRecreate)
                {
                    var dailyMealId = Guid.NewGuid();
                    var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();

                    var newDailyMeal = new Domain.DailyMeal
                    {
                        GoalId = userGoal?.GoalId ?? Guid.Empty,
                        DailyMealId = dailyMealId,
                        UserId = user.Id,
                        CreatedAt = targetDate,  // Giữ đúng ngày cũ
                        UpdatedAt = targetDate,
                        TotalCalories = 0,
                        TotalProteins = 0,
                        TotalCarbs = 0,
                        TotalFats = 0,
                        TotalFibers = 0,
                        TotalSugars = 0,
                        Meals = new List<Domain.Meal>()
                    };

                    // Tạo lại các bữa ăn theo logic của CreateUserSubscription
                    var breakfast = await CreateMealForType(MealType.Breakfast, user, dailyMealId, targetDate);
                    var lunch = await CreateMealForType(MealType.Lunch, user, dailyMealId, targetDate);
                    var dinner = await CreateMealForType(MealType.Dinner, user, dailyMealId, targetDate);

                    newDailyMeal.Meals.Add(breakfast);
                    newDailyMeal.Meals.Add(lunch);
                    newDailyMeal.Meals.Add(dinner);

                    _dailyMealRepository.Add(newDailyMeal);
                    await _dailyMealRepository.SaveChangeAsync();
                }
            }
            // ------------------------

            return true;
        }

        /// <summary>
        /// Phương thức tạo Meal theo logic tương tự như CreateUserSubscription.
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
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
            }
            else if (proteinFood != null && carbFood != null && vegetableFood != null)
            {
                // Nếu không có balanceFood, sử dụng proteinFood, carbFood và vegetableFood
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = proteinFood.FoodId,
                    PortionId = proteinPortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = carbFood.FoodId,
                    PortionId = carbPortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
                mealFoods.Add(new Domain.MealFood
                {
                    FoodId = vegetableFood.FoodId,
                    PortionId = vegetablePortionId,
                    Quantity = 1,
                    IsRecommended = true,
                    IsCompleted = false,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
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
                UpdatedAt = DateTime.UtcNow,
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
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });
                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = vegetablePortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
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
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });
                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = carbPortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)carbWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });
                _portionRepository.Add(new Domain.Portion
                {
                    PortionId = vegetablePortionId,
                    PortionSize = "phần",
                    PortionWeight = (float)vegetableWeight,
                    MeasurementUnit = "g",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedBy = user.Id,
                    UpdatedBy = user.Id,
                });
            }

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
