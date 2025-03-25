using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Schedule.Queries.GetAll;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleQueryHandler : IRequestHandler<GetScheduleByConsultantIdQuery, List<ScheduleDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        public GetScheduleQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
        }

        public async Task<List<ScheduleDTO>> Handle(GetScheduleByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var schedules = await _scheduleRepository.GetSchedulesByUser(request.ConsultantId, request.Date);
            if (schedules == null) throw new BadRequestException("Không tìm thấy lịch");
            var result = schedules.Select(s => new ScheduleDTO
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
            return result;
        }
    }
}