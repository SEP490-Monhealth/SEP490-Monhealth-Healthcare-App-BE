using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
