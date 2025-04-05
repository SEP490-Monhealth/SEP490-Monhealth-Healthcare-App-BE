using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdCommandHandler : IRequestHandler<GetConsultantByIdCommand, GetAllConsultantsDTO>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IMapper _mapper;
        public GetConsultantByIdCommandHandler(IConsultantRepository consultantRepository, IMapper mapper)
        {
            _consultantRepository = consultantRepository;
            _mapper = mapper;
        }
        public async Task<GetAllConsultantsDTO> Handle(GetConsultantByIdCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetConsultantById(request.ConsultantId);
            if (consultant != null)
            {
                consultant.Views += 1;
                _consultantRepository.Update(consultant);
                await _consultantRepository.SaveChangeAsync();
            }
            return _mapper.Map<GetAllConsultantsDTO>(consultant);
        }
    }
}
