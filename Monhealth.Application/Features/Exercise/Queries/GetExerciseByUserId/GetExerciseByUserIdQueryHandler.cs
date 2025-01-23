using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Exercise.Queries.GetExerciseByUserId
{
    public class GetExerciseByUserIdQueryHandler : IRequestHandler<GetExerciseByUserIdQuery, List<GetExerciseByUserIdDTO>>
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;
        public GetExerciseByUserIdQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }
        public async Task<List<GetExerciseByUserIdDTO>> Handle(GetExerciseByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listExercise = await _exerciseRepository.GetExerciseUserIdAsync(request.UserId);
            return _mapper.Map<List<GetExerciseByUserIdDTO>>(listExercise);
        }
    }
}
