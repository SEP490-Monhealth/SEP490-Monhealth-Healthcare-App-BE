using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Booking.Commands.UpdateBooking
{
    public class UpBookingCommandHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<UpdateBookingCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetByIdAsync(request.BookingId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn");
            mapper.Map(request.UpdateBookingDto, booking);
            booking.UpdatedAt = DateTime.Now;
            await bookingRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
