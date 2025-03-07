﻿using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Booking.Queries.GetBookingByConsultantId
{
    public class GetByConsultantIdQueriesHandler(IMapper mapper, IBookingRepository bookingRepository) : IRequestHandler<GetByConsultantIdQueries, GetByConsultantIdDto>
    {
        public async Task<GetByConsultantIdDto> Handle(GetByConsultantIdQueries request, CancellationToken cancellationToken)
        {
            var booking = await bookingRepository.GetBookingByConsultantId(request.ConsultantId);
            if (booking == null) throw new BadRequestException("Không tìm thấy lịch hẹn");
            return mapper.Map<GetByConsultantIdDto>(booking);

        }
    }
}
