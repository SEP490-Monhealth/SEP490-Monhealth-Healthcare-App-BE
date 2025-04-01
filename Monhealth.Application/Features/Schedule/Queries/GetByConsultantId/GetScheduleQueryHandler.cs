using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleQueryHandler : IRequestHandler<GetScheduleByConsultantIdQuery, List<ScheduleDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IBookingRepository bookingRepository;

        public GetScheduleQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository, IBookingRepository bookingRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
            this.bookingRepository = bookingRepository;
        }

        public async Task<List<ScheduleDTO>> Handle(GetScheduleByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var schedules = await _scheduleRepository.GetSchedulesByUser(request.ConsultantId, request.Date.HasValue ? DateOnly.FromDateTime(request.Date.Value) : null);
            if (schedules == null) throw new BadRequestException("Không tìm thấy lịch");
            List<TimeOnly> bookedTimes = new();
            if (request.Date.HasValue)
            {
                bookedTimes = await bookingRepository.GetBookedTimeAsync(request.ConsultantId, DateOnly.FromDateTime(request.Date.Value)); //lay gio da duoc book trong Booking table
            }

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
                    Status = bookedTimes.Contains(st.TimeSlot.StartTime)
                    ? ScheduleTimeSlotStatus.Unavailable
                    : ScheduleTimeSlotStatus.Available,
                }
             ).ToList()
            }).ToList();
            return result;
        }
    }
}