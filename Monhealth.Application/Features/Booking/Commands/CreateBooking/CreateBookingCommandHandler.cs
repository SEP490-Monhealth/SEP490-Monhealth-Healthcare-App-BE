using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository
    , IConsultantRepository consultantRepository,
        IScheduleRepository scheduleRepository,
        IUserSubscriptionRepository userSubscriptionRepository,
        ISystemNotificationService systemNotificationService

        ) : IRequestHandler<CreateBookingCommand, Unit>
    {
        public async Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = mapper.Map<Domain.Booking>(request);
            bookingRepository.Add(booking);

            //plus amout booking for consultant
            var consultant = await consultantRepository.GetByIdAsync((Guid)booking.ConsultantId);
            if (consultant != null)
            {
                consultant.BookingCount += 1;
                consultant.UpdatedAt = DateTime.Now;
            }

            //subtract amout remaining booking
            var userSubscription = await userSubscriptionRepository.GetUserSubscriptionActiveOfUser((Guid)booking.UserId);
            if (userSubscription == null) throw new BadRequestException("Bạn đã hết số lượt có thể đặt lịch");
            userSubscription.RemainingBookings -= 1;
            userSubscription.UpdatedAt = DateTime.Now;

            //Notify booked user and consultant
            await systemNotificationService.NotifyNewBookingAsync(booking, cancellationToken);

            await bookingRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
