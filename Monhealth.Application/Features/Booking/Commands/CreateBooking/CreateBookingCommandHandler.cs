using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository
    , IConsultantRepository consultantRepository,
        IScheduleRepository scheduleRepository,
        IUserSubscriptionRepository userSubscriptionRepository

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
            if (userSubscription == null) throw new Exception("Người dùng này không có quyền booking");

            userSubscription.RemainingBookings -= 1;
            userSubscription.UpdatedAt = DateTime.Now;

            await bookingRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
