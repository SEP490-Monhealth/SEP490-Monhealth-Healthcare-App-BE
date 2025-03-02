using MediatR;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdCommand : IRequest<GetConsultantByIdDTO>
    {
        public Guid ConsultantId { get; set; }
    }
}
