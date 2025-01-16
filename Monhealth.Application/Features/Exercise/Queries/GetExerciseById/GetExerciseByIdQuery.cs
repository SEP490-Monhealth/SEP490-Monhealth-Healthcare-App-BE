using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseById
{
    public class GetExerciseByIdQuery : IRequest<GetExerciseByIdDTO>
    {
        public Guid ExerciseId { get; set; }
    }
}
