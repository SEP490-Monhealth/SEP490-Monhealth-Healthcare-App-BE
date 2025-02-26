using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Expertise.Queries.GetAllExpertises
{
    public class GetAllExpertisesQueryHandler : IRequestHandler<GetAllExpertisesQuery, PageResult<GetAllExpertisesDTO>>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public GetAllExpertisesQueryHandler(IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<PageResult<GetAllExpertisesDTO>> Handle(GetAllExpertisesQuery request, CancellationToken cancellationToken)
        {
            var listExpertise = await _expertiseRepository.GetAllExpertisesAsync(request.Page, request.Limit);
            var listExpertiseDto = _mapper.Map<List<GetAllExpertisesDTO>>(listExpertise.Items);
            return new PageResult<GetAllExpertisesDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listExpertise.TotalCount / (double)request.Limit),
                TotalItems = listExpertise.TotalCount,
                Items = listExpertiseDto
            };
        }
    }
}
