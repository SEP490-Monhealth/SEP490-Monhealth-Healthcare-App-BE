using MediatR;

namespace Monhealth.Application.Features.TimeSlots.Commands.ChangeCompletedTransaction
{
    public class ChangeCompletedTransactionCommand : IRequest<bool>
    {
        public Guid transactionId { get; set; }
    }
}
