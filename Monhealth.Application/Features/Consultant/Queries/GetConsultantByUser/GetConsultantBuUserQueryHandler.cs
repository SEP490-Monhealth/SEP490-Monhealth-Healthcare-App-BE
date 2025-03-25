using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;

namespace Monhealth.Application
{
    public class GetConsultantBuUserQueryHandler : IRequestHandler<GetConsultantByUserQuery, GetAllConsultantsDTO>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IMapper mapper;

        public GetConsultantBuUserQueryHandler(IConsultantRepository consultantRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            this.mapper = mapper;
        }
        public async Task<GetAllConsultantsDTO> Handle(GetConsultantByUserQuery request, CancellationToken cancellationToken)
        {
            var userConsultant = await _consultantRepository.GetConsultantByUserId(request.UserId);
            return mapper.Map<GetAllConsultantsDTO>(userConsultant);
        }
    }
}
