using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Booking.Commands.CreateBooking
{
    public class CreateBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<CreateBookingCommand, Unit>
    {
        public async Task<Unit> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = mapper.Map<Domain.Booking>(request);
            bookingRepository.Add(booking);
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
