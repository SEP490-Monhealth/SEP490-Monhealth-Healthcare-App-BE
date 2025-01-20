using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Schedule.Queries.GetAll
{
    public class GetAllScheduleQueryHandler : IRequestHandler<GetAllScheduleQuery, List<ScheduleDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        public GetAllScheduleQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
        }

        public async Task<List<ScheduleDTO>> Handle(GetAllScheduleQuery request, CancellationToken cancellationToken)
        {
            var queries = await _scheduleRepository.GetAllAsync();
            return _mapper.Map<List<ScheduleDTO>>(queries);
        }
    }
}