using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Booking.Queries.GetAllBookings
{
    public class GetAllBookingQueriesHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<GetAllBookingQueries, PageResult<BookingDto>>
    {
        public async Task<PageResult<BookingDto>> Handle(GetAllBookingQueries request, CancellationToken cancellationToken)
        {
            var pagingBooking = await bookingRepository.GetAllBookingAsync(request.Page, request.Limit, 
            request.Search, request.Status);
            return new PageResult<BookingDto>()
            {
                Items = mapper.Map<List<BookingDto>>(pagingBooking.Items),
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(pagingBooking.TotalCount / (double)request.Limit),
                TotalItems = pagingBooking.TotalCount,
            };
        }
    }
}
