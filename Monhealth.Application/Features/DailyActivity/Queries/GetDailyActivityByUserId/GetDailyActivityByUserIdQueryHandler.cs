using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return _mapper.Map<GetDailyActivityByUserIdDTO>(dailyActivity);
        }
    }
}
