using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class GetAllScheduleQueryHandler : IRequestHandler<GetAllScheduleQuery, PageResult<ScheduleDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        public GetAllScheduleQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
        }
        async Task<PageResult<ScheduleDTO>> IRequestHandler<GetAllScheduleQuery, PageResult<ScheduleDTO>>.Handle(GetAllScheduleQuery request, CancellationToken cancellationToken)
        {
            var queries = await _scheduleRepository.GetAllScheduleAsync(request.Page, request.Limit);
            var result = queries.Items
                .Select(s => new ScheduleDTO
                {
                    ScheduleId = s.ScheduleId,
                    ConsultantId = s.ConsultantId,
                    ScheduleType = s.ScheduleType,
                    RecurringDay = s.RecurringDay,
                    SpecificDate = s.SpecificDate,
                    TimeSlots = s.ScheduleTimeSlots
                    .OrderBy(st => st.TimeSlot.StartTime)
                    .Select(st => new TimeSlotDto
                    {
                        StartTime = st.TimeSlot.StartTime,
                        Status = st.Status,
                    }
                ).ToList()
                }).ToList();
            return new PageResult<ScheduleDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = result
            };
        }
    }
}