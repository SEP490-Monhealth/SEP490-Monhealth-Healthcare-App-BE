using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Expertise.Queries.GetExpertiseById
{
    public class GetExpertiseByIdQueryHandler : IRequestHandler<GetExpertiseByIdQuery, GetExpertiseByIdDTO>
    {
        private readonly IExpertiseRepository _expertiseRepository;
        private readonly IMapper _mapper;
        public GetExpertiseByIdQueryHandler(IExpertiseRepository expertiseRepository, IMapper mapper)
        {
            _expertiseRepository = expertiseRepository;
            _mapper = mapper;
        }
        public async Task<GetExpertiseByIdDTO> Handle(GetExpertiseByIdQuery request, CancellationToken cancellationToken)
        {
            var expertise = await _expertiseRepository.GetByIdAsync(request.ExpertiseId);
            return _mapper.Map<GetExpertiseByIdDTO>(expertise);
        }
    }
}
