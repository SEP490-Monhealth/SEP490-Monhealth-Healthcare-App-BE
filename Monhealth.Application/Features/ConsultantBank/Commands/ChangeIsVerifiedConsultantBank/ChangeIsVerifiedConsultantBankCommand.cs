using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Commands.ChangeIsVerifiedConsultantBank
{
    public class ChangeIsVerifiedConsultantBankCommand : IRequest<bool>
    {
        public Guid ConsultantBankId { get; set; }
    }
}
