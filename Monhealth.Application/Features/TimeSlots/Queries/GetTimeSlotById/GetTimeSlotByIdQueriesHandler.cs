using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots;

namespace Monhealth.Application.Features.TimeSlots.Queries.GetTimeSlotById
{
    public class GetTimeSlotByIdQueriesHandler(ITimeSlotRepository timeSlotRepository, IMapper mapper) : IRequestHandler<GetTimeSlotByIdQueries, TimeSlotDto>
    {
        public async Task<TimeSlotDto> Handle(GetTimeSlotByIdQueries request, CancellationToken cancellationToken)
        {
            var timeSlot = await timeSlotRepository.GetByIdAsync(request.TimeSlotId);
            if (timeSlot == null) throw new BadRequestException("Không tìm thấy khung giờ");
            return mapper.Map<TimeSlotDto>(timeSlot);

        }
    }
}
