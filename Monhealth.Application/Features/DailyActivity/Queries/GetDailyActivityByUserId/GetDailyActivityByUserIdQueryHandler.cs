using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdQueryHandler : IRequestHandler<GetDailyActivityByUserIdQuery, GetDailyActivityByUserIdDTO>
    {
        private readonly IDailyActivityRepository _dailyActivityRepository;
        private readonly IDailyMealRepository _dailyMealRepository;
        private readonly IActivityRepository _activityRepository;
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IMapper _mapper;
        public GetDailyActivityByUserIdQueryHandler(IDailyActivityRepository dailyActivityRepository, 
            IDailyMealRepository dailyMealRepository, 
            IActivityRepository activityRepository,
            IWorkoutRepository workoutRepository,
            IMapper mapper)
        {
            _dailyActivityRepository = dailyActivityRepository;
            _dailyMealRepository = dailyMealRepository;
            _activityRepository = activityRepository;
            _workoutRepository = workoutRepository;
            _mapper = mapper;
        }
        public async Task<GetDailyActivityByUserIdDTO> Handle(GetDailyActivityByUserIdQuery request, CancellationToken cancellationToken)
        {
            var dailyActivity = await _dailyActivityRepository.GetDailyActivityByUserIdAndCreateAt(request.UserId, request.Date);
            if (dailyActivity == null)
            {
                   return new GetDailyActivityByUserIdDTO();
            }
            var dailyMeal = await _dailyMealRepository.GetDailyMealsByCreateAt(request.Date);
            if(dailyMeal == null)
            {
                return new GetDailyActivityByUserIdDTO();
            }
            var activities = await _activityRepository.GetActivitiesByDailyActivityId(dailyActivity.DailyActivityId);

            return new GetDailyActivityByUserIdDTO
            {
                DailyActivityId = dailyActivity.DailyActivityId,
                GoalType = dailyActivity.Goal.GoalType,
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
