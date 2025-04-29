using MediatR;

namespace Monhealth.Application.Features.Workout.Queries.GetWorkoutByUserIdQueries
{
    public class GetWorkoutByUserIdQuery : IRequest<List<GetWorkoutByUserIdDTO>>
    {
        public Guid UserId { get; set; }
        public GetWorkoutByUserIdQuery(Guid userId)
        {
            UserId = userId;
        }
    }
}
