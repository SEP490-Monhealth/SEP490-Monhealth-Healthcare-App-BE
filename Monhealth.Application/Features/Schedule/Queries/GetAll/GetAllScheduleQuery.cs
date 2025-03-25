using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class GetAllScheduleQuery : IRequest<PageResult<ScheduleDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}