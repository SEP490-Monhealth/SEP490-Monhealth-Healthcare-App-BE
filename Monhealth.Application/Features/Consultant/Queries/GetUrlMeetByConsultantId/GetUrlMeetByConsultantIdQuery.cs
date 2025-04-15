using MediatR;

namespace Monhealth.Application.Features.Consultant.Queries.GetUrlMeetByConsultantId
{
    public class GetUrlMeetByConsultantIdQuery : IRequest<GetUrlMeetByConsultantIdDto>
    {
        public Guid ConsultantId { get; set; }

    }
}
