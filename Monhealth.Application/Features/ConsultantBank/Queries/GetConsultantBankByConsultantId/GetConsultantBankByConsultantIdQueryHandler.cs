using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId
{
    public class GetConsultantBankByConsultantIdQueryHandler(IConsultantBankRepository consultantBankRepository, IMapper mapper) : IRequestHandler<GetConsultantBankByConsultantIdQuery, List<GetConsultantBankByConsultantIdDTO>>
    {
        public async Task<List<GetConsultantBankByConsultantIdDTO>> Handle(GetConsultantBankByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var consultantBanks = await consultantBankRepository.GetConsultantBankByConsultantIdAsync(request.ConsultantId);
            return mapper.Map<List<GetConsultantBankByConsultantIdDTO>>(consultantBanks);
        }
    }
}
