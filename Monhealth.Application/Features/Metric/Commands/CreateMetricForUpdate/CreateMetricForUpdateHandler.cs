using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Core.Enum;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application
{
    public class CreateMetricForUpdateRequest : IRequest<Unit>
    {
        public CreateMetricDTO createMetricForUpdateDTO { get; set; }
        public CreateMetricForUpdateRequest(CreateMetricDTO request)
        {
            createMetricForUpdateDTO = request;
        }
    }

    public class CreateMetricForUpdateHandler : IRequestHandler<CreateMetricForUpdateRequest, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IMetricsCalculator _metricCalculator;
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalsCalculator _goalCalculator;
        private readonly IGoalRepository _goalRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;  // Added repository for role check
        private readonly ILogger<CreateMetricForUpdateHandler> _logger;

        public CreateMetricForUpdateHandler(
            IMapper mapper,
            IMetricsCalculator metricCalculator,
            IMetricRepository metricRepository,
            IGoalsCalculator goalCalculator,
            IGoalRepository goalRepository,
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IFoodRepository foodRepository,
            IPortionRepository portionRepository,
            IUserRepository userRepository,
            IUserRoleRepository userRoleRepository,
            ILogger<CreateMetricForUpdateHandler> logger)
        {
            _mapper = mapper;
            _metricCalculator = metricCalculator;
            _metricRepository = metricRepository;
            _goalCalculator = goalCalculator;
            _goalRepository = goalRepository;
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _foodRepository = foodRepository;
            _portionRepository = portionRepository;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            CreateMetricForUpdateRequest request,
            CancellationToken cancellationToken)
        {
            #region Metric Calculation

            var newMetric = _mapper.Map<Monhealth.Domain.Metric>(
                request.createMetricForUpdateDTO);

            var age = DateTime.UtcNow.Year - request.createMetricForUpdateDTO.DateOfBirth.Year;
            if (DateTime.UtcNow.DayOfYear < request.createMetricForUpdateDTO.DateOfBirth.DayOfYear)
            {
                age--;
            }
            newMetric.Bmi = (float)_metricCalculator.CalculateBMI(
                request.createMetricForUpdateDTO.Weight,
                request.createMetricForUpdateDTO.Height);
            newMetric.Bmr = _metricCalculator.CalculateBMR(
                request.createMetricForUpdateDTO.Weight,
                request.createMetricForUpdateDTO.Height,
                age,
                request.createMetricForUpdateDTO.Gender.ToString());
            newMetric.Tdee = _metricCalculator.CalculateTDEE(
                newMetric.Bmr,
                request.createMetricForUpdateDTO.ActivityLevel);
            newMetric.Ibw = _metricCalculator.CalculateIBW(
                request.createMetricForUpdateDTO.Height,
                request.createMetricForUpdateDTO.Gender.ToString());
            newMetric.MetricId = Guid.NewGuid();
            newMetric.CreatedAt = DateTime.UtcNow;
            newMetric.UpdatedAt = DateTime.UtcNow;
            _metricRepository.Add(newMetric);
            await _metricRepository.SaveChangeAsync();

            #endregion

            #region Goal Calculation

            var newGoal = _mapper.Map<Goal>(request.createMetricForUpdateDTO);
            _goalCalculator.CreateCalculateGoal(newGoal,
                request.createMetricForUpdateDTO,
                newMetric.Tdee);
            newGoal.GoalId = Guid.NewGuid();

            var checkStatus =
                await _goalRepository.CheckStatusGoal(request.createMetricForUpdateDTO.UserId);
            if (checkStatus != null)
            {
                checkStatus.Status = GoalStatus.Abandoned;
                _goalRepository.Update(checkStatus);
            }
            newGoal.Status = GoalStatus.Active;
            newGoal.CreatedAt = DateTime.UtcNow;
            newGoal.UpdatedAt = DateTime.UtcNow;
            _goalRepository.Add(newGoal);
            await _goalRepository.SaveChangeAsync();

            #endregion

            // ----- Update DailyMeal -----
            // Chỉ update Recommend Meal nếu người dùng có role "Subscription Member"
            var userRoleEntry = await _userRoleRepository.GetUserRoleByUserIdAsync(newMetric.UserId);
            if (userRoleEntry == null)
            {
                _logger.LogInformation($"User {newMetric.UserId} không có role. Bỏ qua cập nhật DailyMeal.");
                return Unit.Value;
            }
            // Giả sử có thêm 1 phương thức GetRoleByIdAsync để lấy thông tin role theo RoleId
            var role = await _userRoleRepository.GetRoleByIdAsync(userRoleEntry.RoleId);
            if (role == null || !role.Name.Equals("Subscription Member", StringComparison.OrdinalIgnoreCase))
            {
                _logger.LogInformation($"User {newMetric.UserId} không phải là Subscription Member. Bỏ qua cập nhật DailyMeal.");
                return Unit.Value;
            }

            // Lưu ý: logic "trừ ngày hôm nay" được giữ nguyên (chỉ cập nhật DailyMeal từ ngày hôm nay trở đi)
            var today = DateTime.Today;

            // Lấy danh sách các DailyMeal của user có DailyMealDate sau hôm nay
            var dailyMealsToRecreate =
                await _dailyMealRepository.GetDailyMealsAfterDate(newMetric.UserId, today);
            if (dailyMealsToRecreate != null && dailyMealsToRecreate.Any())
            {
                // Lấy các ngày cần tạo lại dựa trên DailyMealDate của từng DailyMeal
                var datesToRecreate = dailyMealsToRecreate
                    .Select(dm => dm.DailyMealDate.Date)
                    .ToList();

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

                // Lấy lại thông tin user để đảm bảo cập nhật theo mục tiêu mới nhất
                var user = await _userRepository.GetUserByIdAsync(newMetric.UserId);
                if (user == null)
                {
                    throw new Exception("Không tìm thấy người dùng.");
                }

                // Tạo lại DailyMeal và các Meal cho đúng các ngày đã xóa
                foreach (var targetDate in datesToRecreate)
                {
                    var dailyMealId = Guid.NewGuid();
                    // Sử dụng mục tiêu mới nhất của người dùng
                    var userGoal = user.Goals.OrderByDescending(g => g.CreatedAt).FirstOrDefault();
                    var newDailyMeal = new Domain.DailyMeal
                    {
                        GoalId = userGoal?.GoalId ?? Guid.Empty,
                        DailyMealId = dailyMealId,
                        UserId = user.Id,
                        DailyMealDate = targetDate, // Ngày của DailyMeal (theo ngày gốc)
                        CreatedAt = DateTime.UtcNow,   // Thời điểm tạo record
                        UpdatedAt = DateTime.UtcNow,
                        TotalCalories = 0,
                        TotalProteins = 0,
                        TotalCarbs = 0,
                        TotalFats = 0,
                        TotalFibers = 0,
                        TotalSugars = 0,
                        Meals = new List<Domain.Meal>()
                    };

                    // Tạo lại các bữa ăn cho DailyMeal - trường MealDate được gán bằng targetDate
                    var breakfast = await CreateMealForType(
                        MealType.Breakfast, user, dailyMealId, targetDate);
                    var lunch = await CreateMealForType(
                        MealType.Lunch, user, dailyMealId, targetDate);
                    var dinner = await CreateMealForType(
                        MealType.Dinner, user, dailyMealId, targetDate);

                    newDailyMeal.Meals.Add(breakfast);
                    newDailyMeal.Meals.Add(lunch);
                    newDailyMeal.Meals.Add(dinner);

                    _dailyMealRepository.Add(newDailyMeal);
                    await _dailyMealRepository.SaveChangeAsync();
                }
            }
            // ------------------------

            return Unit.Value;
        }

        /// <summary>
        /// Phương thức tạo Meal theo logic tương tự như CreateUserSubscription.
        /// Chú ý: 
        /// - Trường MealDate được set bằng targetDate (ngày áp dụng cho bữa ăn)
        /// - CreatedAt/UpdatedAt ghi nhận thời điểm thao tác (DateTime.UtcNow)
        /// </summary>
        private async Task<Domain.Meal> CreateMealForType(
            MealType mealType, AppUser user, Guid dailyMealId, DateTime targetDate)
        {
            // Lấy các thực phẩm ngẫu nhiên theo logic hiện có
            var (proteinFood, carbFood, balanceFood, vegetableFood) =
                await _foodRepository.GetRandomProteinAndCarbFood(new List<Guid>());

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
            var vegetableWeight = 100 * vegetableCalories /
                                  vegetableFood!.Nutrition.Calories;
            vegetableWeight = RoundPortionWeight(
                (float)vegetableWeight, userGoal.GoalType);

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

            // Tạo Meal mới:
            // - Trường MealDate được set bằng targetDate (ngày áp dụng cho bữa ăn)
            // - CreatedAt/UpdatedAt được gán với thời điểm hiện tại
            Domain.Meal meal = new Domain.Meal
            {
                MealType = mealType,
                UserId = user.Id,
                DailyMealId = dailyMealId,
                MealDate = targetDate,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                MealFoods = mealFoods,
            };

            // Thêm các Portion tương ứng cho các món ăn
            if (balanceFood != null)
            {
                var balanceWeight = 100 * balanceCalories /
                                    balanceFood.Nutrition.Calories;
                balanceWeight = RoundPortionWeight(
                    (float)balanceWeight, userGoal.GoalType);

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
                var proteinWeight = 100 * proteinCalories /
                                    proteinFood.Nutrition.Calories;
                var carbWeight = 100 * carbsCalories /
                                 carbFood.Nutrition.Calories;
                proteinWeight = RoundPortionWeight(
                    (float)proteinWeight, userGoal.GoalType);
                carbWeight = RoundPortionWeight(
                    (float)carbWeight, userGoal.GoalType);

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
