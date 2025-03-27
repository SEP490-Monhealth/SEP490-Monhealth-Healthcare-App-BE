using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Commands.ChangeIsDefaultConsultantBank
{
    public class ChangeIsDefaultConsultantBankCommand : IRequest<bool>
    {
        public Guid ConsultantBankId { get; set; }
    }
}
