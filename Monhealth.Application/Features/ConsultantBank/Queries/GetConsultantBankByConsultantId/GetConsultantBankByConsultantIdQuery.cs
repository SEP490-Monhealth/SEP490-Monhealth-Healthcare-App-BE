using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankByConsultantId
{
    public class GetConsultantBankByConsultantIdQuery : IRequest<List<GetConsultantBankByConsultantIdDTO>>
    {
        public Guid ConsultantId { get; set; }
    }
}
