using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Booking.Commands.UpdateEvidensForConsultant
{
    public class UpdateEvidensForConsultantCommandHandler(IBookingRepository bookingRepository) : IRequestHandler<UpdateEvidensForConsultantCommand, bool>
    {
        public async Task<bool> Handle(UpdateEvidensForConsultantCommand request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByBookingIdAsync(request.BookingId)
            ?? throw new BadRequestException($"Không tìm thấy lịch hẹn {request.BookingId}");

            if (request.UpdateEvidensDto.EvidenceUrls == null || request.UpdateEvidensDto.EvidenceUrls.Count == 0)
            {
                throw new BadRequestException("Danh sách EvidenceUrls không được để trống.");
            }

            foreach (var url in request.UpdateEvidensDto.EvidenceUrls)
            {
                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new BadRequestException($"URL '{url}' không hợp lệ.");
                }
            }

            booking.EvidenceUrls = request.UpdateEvidensDto.EvidenceUrls;

            booking.UpdatedAt = DateTime.Now;
            bookingRepository.SaveChangeAsync(cancellationToken);
            return true;
        }

    }
}
