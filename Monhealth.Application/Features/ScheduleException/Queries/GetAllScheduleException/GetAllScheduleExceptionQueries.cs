using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class GetAllScheduleExceptionQueries : IRequest<PageResult<ScheduleExceptionDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetAllScheduleExceptionQueries(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}
