using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Unit>
    {
        private readonly IActivityRepository _activityRepository;
        private readonly IDailyActivityRepository _dailyActivityRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IWorkoutExcerciseRepository _workoutExcerciseRepository;
        private readonly IMapper _mapper;
        public CreateActivityCommandHandler(IActivityRepository activityRepository, 
                                            IDailyActivityRepository dailyActivityRepository, 
                                            IGoalRepository goalRepository,
                                            IWorkoutExcerciseRepository workoutExcerciseRepository,
                                            IMapper mapper)
        {
            _activityRepository = activityRepository;
            _dailyActivityRepository = dailyActivityRepository;
            _goalRepository = goalRepository;
            _workoutExcerciseRepository = workoutExcerciseRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            // Add DailyActiviy
            var getGoal = await _goalRepository.GetGoalByUserIdAndStatusActiveAsync(request.CreateActivityDTO.UserId);
            if(getGoal == null)
            {
                throw new Exception("Mục tiêu không tìm thấy");
            }
            var listWorkoutExercise = await _workoutExcerciseRepository.GetWorkoutExercisesByWorkoutId(request.CreateActivityDTO.WorkoutId);
            int totalDuration = 0;
            float totalCaloriesBurned = 0;

            foreach (var item in listWorkoutExercise)
            {
                totalDuration = listWorkoutExercise.Sum(we => we.Duration + we.Reps * 2);
                totalCaloriesBurned += listWorkoutExercise.Sum(we => (we.Exercise.CaloriesPerMinute * (we.Duration / 60)) + we.Exercise.CaloriesPerMinute * (we.Reps * 2 / 60));
            }
            

            var newDailyActivity = _mapper.Map<Domain.DailyActivity>(request.CreateActivityDTO);
            newDailyActivity.DailyActivityId = Guid.NewGuid();
            newDailyActivity.GoalId = getGoal.GoalId;
            newDailyActivity.TotalDuration = totalDuration;
            newDailyActivity.TotalCaloriesBurned = totalCaloriesBurned;
            newDailyActivity.CreatedAt = DateTime.Now;
            newDailyActivity.UpdatedAt = DateTime.Now;
            _dailyActivityRepository.Add(newDailyActivity);
            await _dailyActivityRepository.SaveChangeAsync();

            var newActivity = _mapper.Map<Domain.Activity>(request.CreateActivityDTO);
            newActivity.ActivityId = Guid.NewGuid();
            newActivity.DailyActivityId = newDailyActivity.DailyActivityId;
            newActivity.Status = false;
            newActivity.CreatedAt = DateTime.Now;
            newActivity.UpdatedAt = DateTime.Now;
            _activityRepository.Add(newActivity);            
            await _activityRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
