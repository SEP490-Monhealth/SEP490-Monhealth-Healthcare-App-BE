using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.ScheduleException.Queries.GetScheduleExceptionByConsultantId
{
    public class GetScheduleExceptionByConsultantIdQueryHandler(IScheduleExceptionRepository scheduleExceptionRepository, IMapper mapper) : IRequestHandler<GetScheduleExceptionByConsultantIdQuery, PageResult<GetScheduleExceptionByConsultantIdDTO>>
    {
        public async Task<PageResult<GetScheduleExceptionByConsultantIdDTO>> Handle(GetScheduleExceptionByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var scheduleExceptions = await scheduleExceptionRepository.GetScheduleExceptionByConsultantIdAsync(request.Page, request.Limit, request.ConsultantId);
            return new PageResult<GetScheduleExceptionByConsultantIdDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(scheduleExceptions.TotalCount / (double)request.Limit),
                TotalItems = scheduleExceptions.TotalCount,
                Items = mapper.Map<List<GetScheduleExceptionByConsultantIdDTO>>(scheduleExceptions.Items)
            };
        }
    }
}
