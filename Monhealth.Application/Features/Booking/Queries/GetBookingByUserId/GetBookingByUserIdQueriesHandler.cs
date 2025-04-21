using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;
using Monhealth.Application.Models.Paging;


namespace Monhealth.Application.Features.Booking.Queries.GetBookingByUserId
{
    public class GetBookingByUserIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository) :
     IRequestHandler<GetBookingByUserIdQueries, PageResult<BookingDto>>
    {
        public async Task<PageResult<BookingDto>> Handle(GetBookingByUserIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByUserId(request.UserId , request.Page, request.Limit);
               return new PageResult<BookingDto>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(booking.TotalCount / (double)request.Limit),
                TotalItems = booking.TotalCount,
                Items = mapper.Map<List<BookingDto>>(booking.Items)
            };
        }
    }
}
