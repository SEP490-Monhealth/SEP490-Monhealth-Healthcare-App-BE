using MediatR;

namespace Monhealth.Application.Features.ConsultantBank.Commands.DeleteConsultantBank
{
    public class DeleteConsultantBankCommand : IRequest<bool>
    {
        public Guid ConsultantBankId { get; set; }
    }
}
