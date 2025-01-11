using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Queries.GetAll
{
    public class GetAllergyQueryHandler : IRequestHandler<GetAllergyQuery, List<AllergyDTO>>
    {
        private readonly IAllergyRepository _allergyRepository;
        private readonly IMapper _mapper;
        public GetAllergyQueryHandler(IAllergyRepository allergyRepository,
        IMapper mapper)
        {
            _allergyRepository = allergyRepository;
            _mapper = mapper;
        }

        public async Task<List<AllergyDTO>> Handle(GetAllergyQuery request, CancellationToken cancellationToken)
        {
            var query = await _allergyRepository.GetAllAsync();
            return _mapper.Map<List<AllergyDTO>>(query);
        }
    }
}