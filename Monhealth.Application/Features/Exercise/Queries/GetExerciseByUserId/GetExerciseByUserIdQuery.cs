using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByUserId
{
    public class GetExerciseByUserIdQuery : IRequest<List<GetExerciseByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
