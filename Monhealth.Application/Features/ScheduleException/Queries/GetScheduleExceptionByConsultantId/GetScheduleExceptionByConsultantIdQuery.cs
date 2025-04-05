using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionByConsultantId
{
    public class GetScheduleExceptionByConsultantIdQuery : IRequest<PageResult<GetScheduleExceptionByConsultantIdDTO>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetScheduleExceptionByConsultantIdQuery(Guid consultantId, int page, int limit)
        {
            ConsultantId = consultantId;
            Page = page;
            Limit = limit;
        }
    }
}
