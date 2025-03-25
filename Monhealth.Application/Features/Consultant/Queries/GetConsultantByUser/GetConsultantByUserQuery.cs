using MediatR;
using Monhealth.Application.Features.Consultant.Queries.GetAllConsultants;

namespace Monhealth.Application
{
    public class GetConsultantByUserQuery : IRequest<GetAllConsultantsDTO>
    {
        public Guid UserId { get; set; }
    }
}