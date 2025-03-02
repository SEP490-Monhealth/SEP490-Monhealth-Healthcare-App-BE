using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdCommandHandler : IRequestHandler<GetConsultantByIdCommand, GetConsultantByIdDTO>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IMapper _mapper;
        public GetConsultantByIdCommandHandler(IConsultantRepository consultantRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _mapper = mapper;
        }
        public async Task<GetConsultantByIdDTO> Handle(GetConsultantByIdCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetConsultantById(request.ConsultantId);
            return _mapper.Map<GetConsultantByIdDTO>(consultant);
        }
    }
}
