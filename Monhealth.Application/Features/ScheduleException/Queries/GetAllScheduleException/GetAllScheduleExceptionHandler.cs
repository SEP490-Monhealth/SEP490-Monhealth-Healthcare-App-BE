using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetAllScheduleException
{
    public class GetAllScheduleExceptionHandler(IScheduleExceptionRepository scheduleExceptionRepository, IMapper mapper) : IRequestHandler<GetAllScheduleExceptionQueries, PageResult<ScheduleExceptionDto>>
    {
        public async Task<PageResult<ScheduleExceptionDto>> Handle(GetAllScheduleExceptionQueries request, CancellationToken cancellationToken)
        {
            var scheduleExceptions = await scheduleExceptionRepository.GetAllScheduleExceptionsAsync(request.Page, request.Limit, request.Search, request.Status);
            return new PageResult<ScheduleExceptionDto>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(scheduleExceptions.TotalCount / (double)request.Limit),
                TotalItems = scheduleExceptions.TotalCount,
                Items = mapper.Map<List<ScheduleExceptionDto>>(scheduleExceptions.Items)
            };
        }
    }
}
