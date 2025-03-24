using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DailyActivity.Queries.GetDailyActivityByUserId
{
    public class GetDailyActivityByUserIdQueryHandler : IRequestHandler<GetDailyActivityByUserIdQuery, GetDailyActivityByUserIdDTO>
    {
        private readonly IDailyActivityRepository _dailyActivityRepository;
        private readonly IMapper _mapper;
        public GetDailyActivityByUserIdQueryHandler(IDailyActivityRepository dailyActivityRepository, IMapper mapper)
        {
            _dailyActivityRepository = dailyActivityRepository;
            _mapper = mapper;
        }
        public async Task<GetDailyActivityByUserIdDTO> Handle(GetDailyActivityByUserIdQuery request, CancellationToken cancellationToken)
        {
            var dailyActivity = await _dailyActivityRepository.GetDailyActivityByUserIdAndCreateAt(request.UserId, request.Date);
            if (dailyActivity == null)
            {
                   return new GetDailyActivityByUserIdDTO();
            }
            return _mapper.Map<GetDailyActivityByUserIdDTO>(dailyActivity);
        }
    }
}
