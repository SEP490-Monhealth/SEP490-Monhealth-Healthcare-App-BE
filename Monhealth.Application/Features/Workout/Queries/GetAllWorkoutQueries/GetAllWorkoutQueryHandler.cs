using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Workout.Queries.GetAllWorkoutQueries
{
    public class GetAllWorkoutQueryHandler(IWorkoutRepository workoutRepository, IMapper mapper) : IRequestHandler<GetAllWorkoutQuery, PageResult<WorkoutDto>>
    {
        public async Task<PageResult<WorkoutDto>> Handle(GetAllWorkoutQuery request, CancellationToken cancellationToken)
        {
            var paginatedWorkout = await workoutRepository.GetAllWorkWithPaging(request.Page, request.Limit, request.CategoryName, request.Search, request.difficulty, request.Popular, request.Status, cancellationToken);
            var result = mapper.Map<IEnumerable<WorkoutDto>>(paginatedWorkout.Items);
            return new PageResult<WorkoutDto>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(paginatedWorkout.TotalCount / (double)request.Limit),
                TotalItems = paginatedWorkout.TotalCount,
                Items = (List<WorkoutDto>)result
            };
        }
    }
}
