using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class GetAllScheduleQueryHandler : IRequestHandler<GetAllScheduleQuery, PageResult<ScheduleDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IBookingRepository bookingRepository;

        public GetAllScheduleQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository, IBookingRepository bookingRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
            this.bookingRepository = bookingRepository;
        }
        async Task<PageResult<ScheduleDTO>> IRequestHandler<GetAllScheduleQuery, PageResult<ScheduleDTO>>.Handle(GetAllScheduleQuery request, CancellationToken cancellationToken)
        {

            var queries = await _scheduleRepository.GetAllScheduleAsync(request.Page, request.Limit);

            // 2. 
            var consultantIds = queries.Items.Select(s => s.ConsultantId).ToList();

            var relatedBookings = await bookingRepository.GetBookingByConsultantIds(consultantIds);

            var result = queries.Items.Select(s =>
            {
                // Ngày cụ thể nếu có, hoặc xác định thứ trong tuần
                DateOnly? specificDate = s.SpecificDate;
                var recurringDay = s.RecurringDay;

                // Lấy các booking theo ngày cụ thể hoặc recurring (chỉ ngày giống nhau)
                var bookedTimeSlots = relatedBookings
                    .Where(b =>
                        b.ConsultantId == s.ConsultantId &&
                        (
                            (specificDate.HasValue && b.Day == specificDate.Value) ||
                            (!specificDate.HasValue && (int)b.Day.DayOfWeek == (int)recurringDay)
                        ))
                    .Select(b => b.StartTime)
                    .ToList();

                return new ScheduleDTO
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
                            TimeSlotId = st.TimeSlotId ?? Guid.Empty,
                            StartTime = st.TimeSlot.StartTime,
                            EndTime = st.TimeSlot.EndTime,
                            Status = bookedTimeSlots.Contains(st.TimeSlot.StartTime)
                                ? ScheduleTimeSlotStatus.Unavailable
                                : ScheduleTimeSlotStatus.Available
                        }).ToList(),
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt,
                };
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