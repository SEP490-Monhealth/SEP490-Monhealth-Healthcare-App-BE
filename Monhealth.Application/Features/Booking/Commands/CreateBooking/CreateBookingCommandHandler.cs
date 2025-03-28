using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository
    , IConsultantRepository consultantRepository,
        IScheduleRepository scheduleRepository
        ) : IRequestHandler<CreateBookingCommand, Unit>
    {
        public async Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = mapper.Map<Domain.Booking>(request);
            bookingRepository.Add(booking);

            //logic change status of TimeSlot 
            DateOnly dateOnly = DateOnly.FromDateTime(request.Day); //covert daytime -> dayonly
            var bookingTime = TimeOnly.FromDateTime(booking.Day);
            var schedule = await scheduleRepository.GetSchedulesByUser(request.ConsultantId, dateOnly);
            if (schedule == null)
                throw new Exception("Không tìm thấy lịch làm việc của chuyên gia trong ngày này.");
            var matchedSlot = schedule.Select(s => s.ScheduleTimeSlots?.FirstOrDefault(st => st.TimeSlot?.StartTime == bookingTime)).FirstOrDefault();
            if (matchedSlot == null)
                throw new Exception("Không tìm thấy khung giờ phù hợp trong lịch làm việc.");
            if (matchedSlot.Status == ScheduleTimeSlotStatus.Unavailable)
                throw new Exception("Khung giờ đã được đặt. Vui lòng chọn khung giờ khác.");
            matchedSlot.Status = ScheduleTimeSlotStatus.Unavailable;

            await bookingRepository.SaveChangeAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
