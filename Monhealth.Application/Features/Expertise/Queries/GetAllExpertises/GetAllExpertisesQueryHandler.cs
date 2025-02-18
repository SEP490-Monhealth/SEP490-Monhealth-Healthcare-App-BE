using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Expertise.Queries.GetAllExpertises
{
    public class GetAllExpertisesQueryHandler : IRequestHandler<GetAllExpertisesQuery, List<GetAllExpertisesDTO>>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public GetAllExpertisesQueryHandler(IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<List<GetAllExpertisesDTO>> Handle(GetAllExpertisesQuery request, CancellationToken cancellationToken)
        {
            var listExpertises = await _expertiseRepository.GetAllAsync();
            return _mapper.Map<List<GetAllExpertisesDTO>>(listExpertises);
        }
    }
}
