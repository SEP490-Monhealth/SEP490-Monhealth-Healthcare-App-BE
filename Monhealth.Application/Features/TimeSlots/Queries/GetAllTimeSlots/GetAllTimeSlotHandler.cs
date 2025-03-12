using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots
{
    public class GetAllTimeSlotHandler(ITimeSlotRepository timeSlotRepository, IMapper mapper) : IRequestHandler<GetAllTimeSlotQueries, List<TimeSlotDto>>
    {
        public async Task<List<TimeSlotDto>> Handle(GetAllTimeSlotQueries request, CancellationToken cancellationToken)
        {
            var timeSlots = await timeSlotRepository.GetAllAsync();

            return mapper.Map<List<TimeSlotDto>>(timeSlots);


        }
    }
}
