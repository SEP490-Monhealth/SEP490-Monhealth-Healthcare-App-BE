using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Allergy.Queries.GetDetail
{
    public class GetAllergyDetailHandler : IRequestHandler<GetAllergyDetailQuery, AllergyDetailDTO>
    {
        private readonly IAllergyRepository _allergyRepository;
        private readonly IMapper _mapper;

        public GetAllergyDetailHandler(IAllergyRepository allergyRepository,
        IMapper mapper)
        {
            _allergyRepository = allergyRepository;
            _mapper = mapper;
        }

        public async Task<AllergyDetailDTO> Handle(GetAllergyDetailQuery request, CancellationToken cancellationToken)
        {
            var query = await _allergyRepository.GetByIdAsync(request.AllergyId);
            if (query == null) { throw new Exception("Không tìm thấy dị ứng."); }
            return _mapper.Map<AllergyDetailDTO>(query);
        }
    }
}