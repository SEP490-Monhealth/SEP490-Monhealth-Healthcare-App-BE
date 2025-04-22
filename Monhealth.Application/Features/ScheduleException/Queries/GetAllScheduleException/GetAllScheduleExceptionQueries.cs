using MediatR;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class GetAllScheduleExceptionQueries : IRequest<PageResult<ScheduleExceptionDto>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public ScheduleExceptionStatus? Status { get; set; }

        public GetAllScheduleExceptionQueries(int page, int limit, string? search, ScheduleExceptionStatus? status)
        {
            Page = page;
            Limit = limit;
            Search = search;
            Status = status;
        }
    }
}
