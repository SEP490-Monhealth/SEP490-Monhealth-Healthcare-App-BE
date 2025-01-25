using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.ServiceForRecommend;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommandHandler : IRequestHandler<CreateMetricCommand, Unit>
    {
        private readonly IMetricsCalculator _metricCalculator;
        private readonly IGoalsCalculator _goalCalculator;
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        private readonly IWaterReminderRepository _reminderRepository;
        private readonly FoodRandomService _foodRandomService; // Inject thêm FoodRandomService
        private readonly IMealRepository _mealRepository;
        private readonly IMealFoodRepository _mealFoodRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodPortionRepository _foodPortionRepository;

        public CreateMetricCommandHandler(
            IMetricRepository metricRepository,
            IMapper mapper,
            IMetricsCalculator metricCalculator,
            IGoalRepository goalRepository,
            IGoalsCalculator goalsCalculator,
            IWaterReminderRepository reminderRepository,
            FoodRandomService foodRandomService, // Inject FoodRandomService
            IMealRepository mealRepository,
            IMealFoodRepository mealFoodRepository,
            IPortionRepository portionRepository,
            IFoodPortionRepository foodPortionRepository)
        {
            _metricCalculator = metricCalculator;
            _metricRepository = metricRepository;
            _mapper = mapper;
            _goalRepository = goalRepository;
            _goalCalculator = goalsCalculator;
            _reminderRepository = reminderRepository;
            _foodRandomService = foodRandomService;
            _mealRepository = mealRepository;
            _mealFoodRepository = mealFoodRepository;
            _portionRepository = portionRepository;
            _foodPortionRepository = foodPortionRepository;
        }

        public async Task<Unit> Handle(CreateMetricCommand request, CancellationToken cancellationToken)
        {
            // Tính toán Metric
            #region Metric Calculation
            var newMetric = _mapper.Map<Monhealth.Domain.Metric>(request.CreateMetricDTO);
            var age = DateTime.Now.Year - request.CreateMetricDTO.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.CreateMetricDTO.DateOfBirth.DayOfYear)
            {
                age--;
            }
            newMetric.Bmi = (float)_metricCalculator.CalculateBMI(request.CreateMetricDTO.Weight, request.CreateMetricDTO.Height);
            newMetric.Bmr = _metricCalculator.CalculateBMR(request.CreateMetricDTO.Weight, request.CreateMetricDTO.Height, age, request.CreateMetricDTO.Gender);
            newMetric.Tdee = _metricCalculator.CalculateTDEE(newMetric.Bmr, request.CreateMetricDTO.ActivityLevel);
            newMetric.Ibw = _metricCalculator.CalculateIBW(request.CreateMetricDTO.Height, request.CreateMetricDTO.Gender);

            newMetric.MetricId = Guid.NewGuid();
            newMetric.CreatedAt = DateTime.Now;
            newMetric.UpdatedAt = DateTime.Now;
            _metricRepository.Add(newMetric);
            #endregion

            // Tính toán Goal
            #region Goal Calculation
            var newGoal = _mapper.Map<Goal>(request.CreateMetricDTO);
            _goalCalculator.CreateCalculateGoal(newGoal, request.CreateMetricDTO, newMetric.Tdee);
            newGoal.GoalId = newMetric.MetricId;
            newGoal.Status = GoalStatus.Active;
            newGoal.CreatedAt = DateTime.Now;
            newGoal.UpdatedAt = DateTime.Now;
            _goalRepository.Add(newGoal);
            await _goalRepository.SaveChangeAsync();
            #endregion

            // Tạo Reminder
            #region Reminder Creation
            Guid? userId = request.CreateMetricDTO.UserId;
            var reminders = await _reminderRepository.CreateReminders(newGoal.WaterGoal, userId);
            foreach (var reminder in reminders)
            {
                _reminderRepository.Add(reminder);
            }
            await _reminderRepository.SaveChangeAsync();
            #endregion

            // **Tạo Meal cho 7 ngày**
            #region Generate Meals for 7 Days
            for (int i = 0; i < 7; i++) // Lặp 7 ngày
            {
                var currentDate = DateTime.Now.Date.AddDays(i); // Ngày hiện tại + i ngày
                var mealPlan = await _foodRandomService.GetMealPlanWithAllocationAsync(userId.Value);

                // Tạo từng loại meal (Breakfast, Lunch, Dinner)
                await CreateMealAsync("Breakfast", mealPlan.Breakfast, userId.Value, currentDate);
                await CreateMealAsync("Lunch", mealPlan.Lunch, userId.Value, currentDate);
                await CreateMealAsync("Dinner", mealPlan.Dinner, userId.Value, currentDate);
            }
            #endregion

            return Unit.Value;
        }

        private async Task CreateMealAsync(string mealType, MealDTO meal, Guid userId, DateTime date)
        {
            if (meal.MainDish == null) return; // Nếu meal rỗng thì bỏ qua

            // Check nếu meal đã tồn tại
            var existingMeal = await _mealRepository.GetByUserIdAndMealType(userId, mealType, date.Day);
            Monhealth.Domain.Meal model;

            if (existingMeal != null)
            {
                model = existingMeal;
                model.UpdatedAt = DateTime.Now;
            }
            else
            {
                model = new Monhealth.Domain.Meal
                {
                    UserId = userId,
                    MealType = mealType,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _mealRepository.Add(model);
                await _mealRepository.SaveChangeAsync();
            }

            // Tạo từng dish trong meal
            await AddDishToMealAsync(meal.MainDish, model.MealId);
            if (meal.SideDish != null) await AddDishToMealAsync(meal.SideDish, model.MealId);
            if (meal.Dessert != null) await AddDishToMealAsync(meal.Dessert, model.MealId);
        }

        private async Task AddDishToMealAsync(DishDTO dish, Guid mealId)
        {
            // Check nếu portion đã tồn tại trong DB với MeasurementUnit, PortionSize, và PortionWeight
            var existingPortion = await _portionRepository.GetPortionAsync(
                dish.Portion?.MeasurementUnit ?? "g", // MeasurementUnit
                dish.Portion?.PortionSize ?? "default", // PortionSize là string
                dish.Portion?.PortionWeight ?? 100 // PortionWeight từ random DishDTO
            );

            Portion portion;
            if (existingPortion != null)
            {
                // Nếu portion đã tồn tại
                portion = existingPortion;
            }
            else
            {
                // Nếu portion chưa tồn tại, tạo mới
                portion = new Portion
                {
                    MeasurementUnit = dish.Portion?.MeasurementUnit ?? "g", // MeasurementUnit
                    PortionSize = dish.Portion?.PortionSize ?? "", // PortionSize từ DishDTO
                    PortionWeight = dish.Portion?.PortionWeight ?? 100, // PortionWeight từ DishDTO
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _portionRepository.Add(portion);
                await _portionRepository.SaveChangesAsync();
            }

            // Map portion vào foodPortion
            _foodPortionRepository.Add(new FoodPortion
            {
                FoodId = dish.Food.FoodId,
                PortionId = portion.PortionId
            });

            // Thêm dish vào MealFood
            _mealFoodRepository.Add(new Monhealth.Domain.MealFood
            {
                MealId = mealId,
                FoodId = dish.Food.FoodId,
                PortionId = portion.PortionId, // Gắn PortionId đã lấy hoặc tạo mới
                Quantity = 1, // Số lượng mặc định là 1
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            await _mealRepository.SaveChangeAsync();
        }

    }
}
