using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingById
{
    public class GetBookingByIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<GetBookingByIdQueries, BookingDto>
    {
        public async Task<BookingDto> Handle(GetBookingByIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByBookingIdAsync(request.BookingId);
            return mapper.Map<BookingDto>(booking);
        }
    }
}
