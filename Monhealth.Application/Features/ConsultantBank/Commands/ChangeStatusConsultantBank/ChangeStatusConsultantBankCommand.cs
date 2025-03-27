using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Commands.ChangeStatusConsultantBank
{
    public class ChangeStatusConsultantBankCommand : IRequest<bool>
    {
        public Guid ConsultantBankId { get; set; }
    }
}
