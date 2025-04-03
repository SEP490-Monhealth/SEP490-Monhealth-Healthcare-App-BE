using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Unit>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IDailyActivityRepository _dailyActivityRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IWorkoutRepository _workoutRepository;
        private readonly IMapper _mapper;

        public CreateActivityCommandHandler(IActivityRepository activityRepository,
                                            IDailyActivityRepository dailyActivityRepository,
                                            IGoalRepository goalRepository,
                                            IWorkoutRepository workoutRepository,
                                            IMapper mapper)
        {
            _activityRepository = activityRepository;
            _dailyActivityRepository = dailyActivityRepository;
            _goalRepository = goalRepository;
            _workoutRepository = workoutRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var today = DateTime.Today;
            var getGoal = await _goalRepository.GetGoalByUserIdAndStatusActive(request.CreateActivityDTO.UserId);
            if (getGoal == null)
            {
                throw new Exception("Mục tiêu không tồn tại");
            }
            // kiem tra xem hom nay co DailyActivity chua
            var dailyActivity = await _dailyActivityRepository.GetDailyActivityByUserIdAndCreateAt(request.CreateActivityDTO.UserId, today);
            // Neu da co Activity cho ngay hom nay
            if (dailyActivity != null)
            {
                // Lay tat ca cac Workout cua UserId
                var workout = await _workoutRepository.GetByIdAsync(request.CreateActivityDTO.WorkoutId);
                // Cong don TotalDuration va TotalCaloriesBurned
                dailyActivity.TotalDurationMinutes += workout.DurationMinutes;
                dailyActivity.TotalCaloriesBurned += workout.CaloriesBurned;
                dailyActivity.UpdatedAt = DateTime.Now;
                // Cap nhat lai DailyActivity
                _dailyActivityRepository.Update(dailyActivity);

                var newActivity = _mapper.Map<Domain.Activity>(request.CreateActivityDTO);
                newActivity.ActivityId = Guid.NewGuid();
                newActivity.DailyActivityId = dailyActivity.DailyActivityId;
                newActivity.CreatedAt = DateTime.Now;
                newActivity.UpdatedAt = DateTime.Now;
                _activityRepository.Add(newActivity);
            }
            else
            {
                // Neu chua co DailyActivity cho ngay hom nay thi tao moi DailyActivity
                var newDailyActivity = _mapper.Map<Domain.DailyActivity>(request.CreateActivityDTO);
                newDailyActivity.DailyActivityId = Guid.NewGuid();
                newDailyActivity.GoalId = getGoal.GoalId;

                var getWorkouts = await _workoutRepository.GetByIdAsync(request.CreateActivityDTO.WorkoutId);
                newDailyActivity.TotalDurationMinutes = getWorkouts.DurationMinutes;
                newDailyActivity.TotalCaloriesBurned = getWorkouts.CaloriesBurned;
                newDailyActivity.CreatedAt = DateTime.Now;
                newDailyActivity.UpdatedAt = DateTime.Now;
                _dailyActivityRepository.Add(newDailyActivity);

                var newActivity = _mapper.Map<Domain.Activity>(request.CreateActivityDTO);
                newActivity.ActivityId = Guid.NewGuid();
                newActivity.DailyActivityId = newDailyActivity.DailyActivityId;
                newActivity.CreatedAt = DateTime.Now;
                newActivity.UpdatedAt = DateTime.Now;
                _activityRepository.Add(newActivity);
            }

            await _activityRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}