using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Schedule.Queries.GetAll;

namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class ScheduleDetailQueryHandler : IRequestHandler<GetDetailScheduleQuery, ScheduleDTO>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleDetailQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
        }

        public async Task<ScheduleDTO> Handle(GetDetailScheduleQuery request, CancellationToken cancellationToken)
        {
            var schedule = await _scheduleRepository.GetScheduleByIdAsync(request.ScheduleId);
            if (schedule == null) throw new BadRequestException("Không tìm thấy lịch");

            return new ScheduleDTO
            {
                ScheduleId = schedule.ScheduleId,
                ConsultantId = schedule.ConsultantId,
                ScheduleType = schedule.ScheduleType,
                RecurringDay = schedule.RecurringDay,
                SpecificDate = schedule.SpecificDate,
                // Nếu có các thông tin liên quan khác từ ScheduleTimeSlots, bạn có thể ánh xạ thêm ở đây.
                TimeSlots = schedule.ScheduleTimeSlots
                .OrderBy(st => st.TimeSlot.StartTime)
                .Select(st => new TimeSlotDto
                {
                    TimeSlotId = st.TimeSlotId ?? Guid.Empty,
                    StartTime = st.TimeSlot.StartTime,
                    EndTime = st.TimeSlot.EndTime,
                    Status = st.Status,
                }).ToList(),
                CreatedAt = schedule.CreatedAt,
                UpdatedAt = schedule.UpdatedAt
            };


        }
    }
}