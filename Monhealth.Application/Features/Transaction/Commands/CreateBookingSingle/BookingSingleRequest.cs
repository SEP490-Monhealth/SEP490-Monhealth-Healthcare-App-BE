using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.CreateBookingSingle
{
    public class BookingSingleRequest : IRequest<BookingSingleResponse>
    {
        public Guid UserId { get; set; }
        //public Guid? UserSubscriptionId { get; set; }
        public string? Description { get; set; }
        public int Amount { get; set; }
    }
}
