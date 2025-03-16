using System.Text.Json;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class ChatBotAiListQueryHandler : IRequestHandler<ChatBotAiListQuery, (ChatBotAi, int)>
    {
        private readonly IMetricRepository _metricRepository;
        private readonly IFoodRepository _foodRepository;
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IUserRepository _userRepository;

        public ChatBotAiListQueryHandler(IMetricRepository metricRepository,
            IFoodRepository foodRepository, IWorkoutRepository workoutRepository,
            IUserRepository userRepository)
        {
            _foodRepository = foodRepository;
            _workoutRepository = workoutRepository;
            _metricRepository = metricRepository;
            _userRepository = userRepository;
        }

        public async Task<(ChatBotAi, int)> Handle(ChatBotAiListQuery request, CancellationToken cancellationToken)
        {
            // Kiểm tra null cho user
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            // Kiểm tra null cho metrics
            var metrics = await _metricRepository.GetByUserIdAsync(request.UserId);
            if (metrics == null)
            {
                throw new Exception("Metrics not found for the user.");
            }

            // Kiểm tra null cho foods
            var foods = await _foodRepository.GetFoodByUserHasNoAllergiesAsync(request.UserId) ?? new List<Food>();

            // Loại bỏ bất kỳ thực phẩm nào có giá trị null
            foods = foods.Where(f => f != null).ToList();

            // Kiểm tra null cho workouts
            var workouts = await _workoutRepository.GetAllAsync() ?? new List<Workout>();

            // Tạo danh sách tên bài tập (WorkoutName)
            var workoutNames = workouts
                .Where(w => !string.IsNullOrEmpty(w.WorkoutName))
                .Select(w => w.WorkoutName)
                .ToList();

            // Tạo danh sách thực phẩm với nhóm FoodName và Nutrition tương ứng
            var foodDTOs = foods
                .Where(f => f != null && f.Nutrition != null) // Kiểm tra null
                .GroupBy(f => new
                {
                    Calories = f.Nutrition?.Calories ?? 0, // Tránh null reference
                    Protein = f.Nutrition?.Protein ?? 0,
                    Carbs = f.Nutrition?.Carbs ?? 0,
                    Fat = f.Nutrition?.Fat ?? 0
                })
                .Select(g => new FoodDTO12
                {
                    FoodName = g
                        .Where(f => !string.IsNullOrEmpty(f.FoodName)) // Loại bỏ tên thực phẩm null
                        .Select(f => f.FoodName)
                        .ToList(),
                    Calories = g.Key.Calories,
                    Protein = g.Key.Protein,
                    Carbs = g.Key.Carbs,
                    Fat = g.Key.Fat
                })
                .ToList();

            // Tạo đối tượng ChatBotAi
            var chatBotAi = new ChatBotAi
            {
                UserName = user.UserName ?? string.Empty,
                Metric = new MetricDTO12
                {
                    Height = metrics.Height,
                    Weight = metrics.Weight,
                    Bmi = metrics.Bmi,
                    Bmr = metrics.Bmr,
                    Tdee = metrics.Tdee,
                    Ibw = metrics.Ibw
                },
                Foods = foodDTOs, // Gán danh sách Foods đã nhóm
                Workouts = new WorkoutDTO12
                {
                    WorkoutName = workoutNames // Gán danh sách bài tập
                }
            };

            // Chuyển đổi đối tượng thành JSON và đếm số ký tự
            var jsonString = JsonSerializer.Serialize(chatBotAi);
            int characterCount = jsonString.Length;

            return (chatBotAi, characterCount);
        }


    }

}