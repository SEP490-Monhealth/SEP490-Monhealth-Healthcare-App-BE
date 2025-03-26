using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.CreateTransaction
{
    public class CreateTransactionCommand : IRequest<Unit>
    {
        public CreateTransactionDTO CreateTransactionDTO { get; set; }
        public CreateTransactionCommand(CreateTransactionDTO createTransactionDTO)
        {
            CreateTransactionDTO = createTransactionDTO;
        }
    }
}
