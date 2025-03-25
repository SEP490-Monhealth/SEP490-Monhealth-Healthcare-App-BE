using MediatR;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;

namespace Monhealth.Application.Features.Consultant.Queries.GetConsultantById
{
    public class GetConsultantByIdCommand : IRequest<GetAllConsultantsDTO>
    {
        public Guid ConsultantId { get; set; }
    }
}
