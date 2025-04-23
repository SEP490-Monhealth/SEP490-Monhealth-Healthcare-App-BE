using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Booking.Queries.GetAllBookings;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository, IReportRepository reportRepository) : IRequestHandler<GetByConsultantIdQueries, List<BookingDto>>
    {
        public async Task<List<BookingDto>> Handle(GetByConsultantIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByConsultantId(request.ConsultantId, request.Date);

            var bookingDtos = mapper.Map<List<BookingDto>>(booking);

            var bookingId = bookingDtos.Select(b => b.BookingId).ToList();

            var reportedBookingIds = await reportRepository.GetReportedBookingIdsAsync(bookingId);

            bookingDtos.ForEach(dto => dto.IsReported = reportedBookingIds.Contains(dto.BookingId));

            return bookingDtos;
        }
    }
}
