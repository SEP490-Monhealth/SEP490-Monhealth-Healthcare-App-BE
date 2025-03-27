using MediatR;

namespace Monhealth.Application.Features.Bank.Commands.ChangeStatusBank
{
    public class ChangeStatusBankCommand : IRequest<bool>
    {
        public Guid BankId { get; set; }
    }
}
