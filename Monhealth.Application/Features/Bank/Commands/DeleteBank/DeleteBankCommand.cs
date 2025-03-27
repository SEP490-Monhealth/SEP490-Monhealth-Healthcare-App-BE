using MediatR;

namespace Monhealth.Application.Features.Bank.Commands.DeleteBank
{
    public class DeleteBankCommand : IRequest<bool>
    {
        public Guid BankId { get; set; }
    }
}
