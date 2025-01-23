using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Exercise.Queries.GetAllExercises
{
    public class GetAllExercisesQueryHandler : IRequestHandler<GetAllExercisesQuery, PageResult<GetAllExercisesDTO>>
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;
        public GetAllExercisesQueryHandler(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }

        public async Task<PageResult<GetAllExercisesDTO>> Handle(GetAllExercisesQuery request, CancellationToken cancellationToken)
        {
            var listExercise = await _exerciseRepository.GetAllExerciseAsync(request.Page, request.Limit, request.Search, request.Popular, request.ExerciseType, request.Status);
            var listExerciseDto = _mapper.Map<List<GetAllExercisesDTO>>(listExercise.Items);
            return new PageResult<GetAllExercisesDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listExercise.TotalCount / (double)request.Limit),
                TotalItems = listExercise.TotalCount,
                Items = listExerciseDto
            };
        }
    }
}
