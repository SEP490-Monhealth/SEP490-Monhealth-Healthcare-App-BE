using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Queries.GetConsultantBankById
{
    public class GetConsultantBankByIdQuery : IRequest<GetConsultantBankByIdDTO>
    {
        public Guid ConsultantBankId { get; set; }
    }
}
