using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdQueryHandler : IRequestHandler<GetDailyActivityByUserIdQuery, GetDailyActivityByUserIdDTO>
    {
        private readonly IDailyActivityRepository _dailyActivityRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IActivityRepository _activityRepository;
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IMapper _mapper;
        private readonly IGoalRepository goalRepository;

        public GetDailyActivityByUserIdQueryHandler(IDailyActivityRepository dailyActivityRepository,
            IDailyMealRepository dailyMealRepository,
            IActivityRepository activityRepository,
            IWorkoutRepository workoutRepository,
            IMapper mapper,
            IGoalRepository goalRepository
            )
        {
            _dailyActivityRepository = dailyActivityRepository;
            _dailyMealRepository = dailyMealRepository;
            _activityRepository = activityRepository;
            _workoutRepository = workoutRepository;
            _mapper = mapper;
            this.goalRepository = goalRepository;
        }
        public async Task<GetDailyActivityByUserIdDTO> Handle(GetDailyActivityByUserIdQuery request, CancellationToken cancellationToken)
        {
            var dailyActivity = await _dailyActivityRepository.GetDailyActivityByUserIdAndCreateAt(request.UserId, request.Date);
            var goal = await goalRepository.GetGoalByUser(request.UserId);
            if (goal == null) throw new BadRequestException("Không tìm thấy mục tiêu của người dùng");
            if (dailyActivity == null)
            {
                return new GetDailyActivityByUserIdDTO
                {
                    GoalType = goal.GoalType
                };
            }
            var dailyMeal = await _dailyMealRepository.GetDailyMealsByCreateAt(request.Date);
            if (dailyMeal == null)
            {
                return new GetDailyActivityByUserIdDTO();
            }
            var activities = await _activityRepository.GetActivitiesByDailyActivityId(dailyActivity.DailyActivityId);

            return new GetDailyActivityByUserIdDTO
            {
                DailyActivityId = dailyActivity.DailyActivityId,
                GoalType = goal.GoalType,
                TotalCaloriesIntake = dailyMeal.TotalCalories,
                TotalCaloriesBurned = dailyActivity.TotalCaloriesBurned,
                TotalDurationMinutes = dailyActivity.TotalDurationMinutes,
                Items = _mapper.Map<List<ActivityDTO>>(activities),
                CreatedAt = dailyActivity.CreatedAt,
                UpdatedAt = dailyActivity.UpdatedAt
            };
        }
    }
}
