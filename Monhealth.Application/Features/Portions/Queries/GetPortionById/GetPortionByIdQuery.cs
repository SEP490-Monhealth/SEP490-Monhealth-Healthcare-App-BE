using MediatR;

namespace Monhealth.Application.Features.Portions.Queries.GetPortionById
{
    public class GetPortionByIdQuery : IRequest<GetPortionByIdDto>
    {
        public Guid PortionId { get; set; }
    }
}
