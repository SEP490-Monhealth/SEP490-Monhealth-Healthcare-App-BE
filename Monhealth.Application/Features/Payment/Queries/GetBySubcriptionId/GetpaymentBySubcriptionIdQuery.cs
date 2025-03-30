using MediatR;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetpaymentBySubcriptionIdQuery : IRequest<List<GetpaymentBySubcriptionIdDTO>>
    {
        public Guid SubcriptionId { get; set; }
    }
}
