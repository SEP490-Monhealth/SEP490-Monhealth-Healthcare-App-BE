using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Schedule.Queries.GetByUser
{
    public class GetScheduleQueryHandler : IRequestHandler<GetScheduleByUserQuery, List<GetScheduleByUserDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        public GetScheduleQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
        }

        public async Task<List<GetScheduleByUserDTO>> Handle(GetScheduleByUserQuery request, CancellationToken cancellationToken)
        {
           var user = await _scheduleRepository.GetSchedulesByUser(request.UserId);
           return _mapper.Map<List<GetScheduleByUserDTO>>(user); 
        }
    }
}