using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Queries.GetByUser
{
    public class GetAllergyByUserQueryHandler : IRequestHandler<GetAllergyByUserQuery, List<AllergyByUserDTO>>
    {
        private readonly IAllergyRepository _allergyRepository;
        private readonly IMapper _mapper;
        public GetAllergyByUserQueryHandler(IAllergyRepository allergyRepository,
        IMapper mapper)
        {
            _allergyRepository = allergyRepository;
            _mapper = mapper;
        }

        public async Task<List<AllergyByUserDTO>> Handle(GetAllergyByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _allergyRepository.GetByUserId(request.UserId);
            return _mapper.Map<List<AllergyByUserDTO>>(query);
        }
    }
}