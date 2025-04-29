using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.ScheduleException.Commands.CreateScheduleException
{
    public class CreateScheduleExceptionCommandHandler(IMapper mapper,
        IScheduleExceptionRepository scheduleExceptionRepository,
        IBookingRepository bookingRepository
        )
        : IRequestHandler<CreateScheduleExceptionCommand, Unit>
    {
        public async Task<Unit> Handle(CreateScheduleExceptionCommand request, CancellationToken cancellationToken)
        {
            // check xem hom nay co lich nghi chua
            var existingScheduleExceptionPending = await scheduleExceptionRepository.CheckScheduleIsExceptionPending(request.ConsultantId, request.Date);
            if(existingScheduleExceptionPending != null)
            {
                throw new Exception($"Không thể tạo thêm, lịch nghỉ ngày {existingScheduleExceptionPending.Date.ToString("dd/MM/yyyy")} chưa được duyệt.");
            }
            var existingScheduleExceptionApproved = await scheduleExceptionRepository.CheckScheduleIsExceptionApproved(request.ConsultantId, request.Date);
            if (existingScheduleExceptionApproved != null)
            {
                throw new Exception($"Không thể tạo thêm, ngày {existingScheduleExceptionApproved.Date.ToString("dd/MM/yyyy")} đã có lịch nghỉ.");
            }
            var scheduleException = mapper.Map<Domain.ScheduleException>(request);

            var bookings = await bookingRepository.GetBookingsByConsultantIdAndDate((Guid)request.ConsultantId, request.Date);
            if (bookings == null || !bookings.Any())
            {
                scheduleException.Status = ScheduleExceptionStatus.Approved;
            }
            scheduleExceptionRepository.Add(scheduleException);
            await scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
