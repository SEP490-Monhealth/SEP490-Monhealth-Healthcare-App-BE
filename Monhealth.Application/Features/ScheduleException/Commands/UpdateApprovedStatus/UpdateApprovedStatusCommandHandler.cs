using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateApprovedStatus
{
    public class UpdateApprovedStatusCommandHandler(IScheduleExceptionRepository scheduleExceptionRepository,
        IBookingRepository bookingRepository,
        ISystemNotificationService systemNotificationService,
        IUserSubscriptionRepository userSubscriptionRepository
        ) : IRequestHandler<UpdateApprovedStatusCommand, bool>
    {
        public async Task<bool> Handle(UpdateApprovedStatusCommand request, CancellationToken cancellationToken)
        {

            var scheduleException = await scheduleExceptionRepository.GetScheduleExceptionByIdAsync(request.ScheduleExceptionId)
            ?? throw new BadRequestException("Không tìm thấy lịch bận");

            var conflictingBookings = await bookingRepository.GetBookingsByConsultantIdAndDate(scheduleException.ConsultantId, scheduleException.Date);

            foreach (var booking in conflictingBookings)
            {
                booking.Status = BookingStatus.Cancelled;

                // Gửi thông báo cho người dùng
                await systemNotificationService.SendBookingCancellationNotificationAsync(booking, cancellationToken);

                //plus amout remaining booking
                var userSubscription = await userSubscriptionRepository.GetUserSubscriptionActiveOfUser((Guid)booking.UserId);
                if (userSubscription == null) throw new Exception("Không tìm thấy gói người dùng");

                userSubscription.RemainingBookings += 1;
                userSubscription.UpdatedAt = DateTime.Now;
            }

            scheduleException.Status = ScheduleExceptionStatus.Approved;
            scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
