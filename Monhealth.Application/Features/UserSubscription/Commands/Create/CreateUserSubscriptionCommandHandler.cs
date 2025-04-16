using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core.Enum;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create
{
    public class CreateUserSubscriptionCommandHandler : IRequestHandler<CreateUserSubscriptionCommand, Unit>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<CreateUserSubscriptionCommandHandler> _logger;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IMealRepository _mealRepository;
        private readonly IPortionRepository _portionRepository;
        private readonly IFoodRepository _foodRepository;

        public CreateUserSubscriptionCommandHandler(
            IUserSubscriptionRepository userSubscriptionRepository,
            ISubscriptionRepository subscriptionRepository,
            ILogger<CreateUserSubscriptionCommandHandler> logger,
            IUserRepository userRepository,
            IUserRoleRepository userRoleRepository,
            IDailyMealRepository dailyMealRepository,
            IMealRepository mealRepository,
            IPortionRepository portionRepository,
            IFoodRepository foodRepository
           )
        {
            _userSubscriptionRepository = userSubscriptionRepository;
            _subscriptionRepository = subscriptionRepository;
            _logger = logger;
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _dailyMealRepository = dailyMealRepository;
            _mealRepository = mealRepository;
            _portionRepository = portionRepository;
            _foodRepository = foodRepository;
        }

        public async Task<Unit> Handle(CreateUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var user = request.UserId;

            var subscription = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
            if (subscription is null)
            {
                _logger.LogError("Subscription not found.");
                throw new Exception("Subscription not found.");
            }

            // Giả sử chúng ta định nghĩa GUID cho gói cơ bản (Basic Subscription)
            var basicSubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759");

            // Kiểm tra xem user đã có record đăng ký nào có SubscriptionId là gói căn bản chưa.
            var existingSubscriptions = await _userSubscriptionRepository.GetUserSubscriptionsByUserIdAsync(user);
            if (existingSubscriptions != null)
            {
                foreach (var userSub in existingSubscriptions)
                {
                    if (userSub.SubscriptionId == basicSubscriptionId &&
                        userSub.Status == UserSubscriptionStatus.Active)
                    {
                        userSub.Status = UserSubscriptionStatus.Expired;
                        userSub.UpdatedAt = DateTime.Now;
                        _userSubscriptionRepository.Update(userSub);
                        _logger.LogInformation($"User's basic subscription {userSub.UserSubscriptionId} set to Expired.");
                    }
                }
            }

            var durationDays = subscription.DurationDays;
            var today = DateTime.Now;
            var model = new Domain.UserSubscription
            {
                SubscriptionId = request.SubscriptionId,
                UserId = user,
                StartedAt = today,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = today,
                UpdatedAt = today,
                ExpiresAt = today.AddDays(durationDays),
                RemainingBookings = subscription.BookingAllowance
            };
            _userSubscriptionRepository.Add(model);

            // Lấy thông tin role "Subscription Member"
            var subscriptionRole = await _userRoleRepository.GetRoleByNameAsync("Subscription Member");
            if (subscriptionRole == null)
            {
                _logger.LogError("Role 'Subscription Member' does not exist.");
                return Unit.Value;
            }
            var userRole = await _userRoleRepository.GetUserRoleByUserIdAsync(user);
            if (userRole != null)
            {
                // Nếu user đã có role, xóa bản ghi cũ trước khi thêm role mới
                _userRoleRepository.Remove(userRole);
                _logger.LogInformation($"Removed old role for UserId {user}");
            }

            // Tạo mới bản ghi UserRole với RoleId lấy từ subscriptionRole
            var newUserRole = new IdentityUserRole<Guid>
            {
                UserId = user,
                RoleId = subscriptionRole.Id
            };
            _userRoleRepository.Add(newUserRole);

            //// Cập nhật lại UserSubscriptionId cho bảng Payment
            //var payment = await paymentRepository.GetByIdAsync(request.PaymentId);
            //if (payment == null)
            //{
            //    throw new BadRequestException($"Thanh toán {request.PaymentId} này không tìm thấy");
            //}
            //payment.UserSubscriptionId = model.UserSubscriptionId;
            //payment.Status = Core.PaymentStatus.Completed;

            var gettingUser = await _userRepository.GetUserByIdAsync(user);

            int daysToCreate = 7; // Số ngày muốn tạo DailyMeal mới
            DateTime startDate = DateTime.Now.Date; // Bắt đầu từ hôm nay

            for (int i = 0; i < daysToCreate; i++)
            {
                DateTime targetDate = startDate.AddDays(i);

                // Nếu DailyMeal của user đã tồn tại cho targetDate thì tăng ngày cho đến khi tìm ngày chưa có
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
                    DailyMealDate = targetDate,
                    DailyMealId = dailyMealId,
                    UserId = user,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
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

                _dailyMealRepository.Add(newDailyMeal);

                // Lưu các thay đổi (DailyMeal, UserSubscription updates, Role updates, ...)
                await _userRepository.SaveChangesAsync();
            }
            return Unit.Value;
        }

        /// <summary>
        /// Tạo Meal cho từng bữa ăn dựa trên loại bữa, liên kết với DailyMealId và targetDate xác định.
        /// </summary>
        private async Task<Domain.Meal> CreateMealForType(MealType mealType, AppUser user, Guid dailyMealId, DateTime targetDate)
        {
            // Lấy các thực phẩm ngẫu nhiên theo logic của bạn
            var (proteinFood, carbFood, balanceFood, vegetableFood) = await _foodRepository.GetRandomProteinAndCarbFood(new List<Guid>());

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

            Domain.Meal meal = new Domain.Meal
            {
                MealType = mealType,
                UserId = user.Id,
                DailyMealId = dailyMealId,
                CreatedAt = DateTime.Now,
                MealDate = targetDate,
                UpdatedAt = DateTime.Now,
                
                MealFoods = mealFoods
            };

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
