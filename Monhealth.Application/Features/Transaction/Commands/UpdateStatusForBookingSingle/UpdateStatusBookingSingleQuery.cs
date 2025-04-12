using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle
{
    public class UpdateStatusBookingSingleQuery : IRequest<bool>
    {
        public long OrderCode { get; set; }
    }
}
