using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Queries.GetById
{
    public class ScheduleDetailQueryHandler : IRequestHandler<GetDetailScheduleQuery, ScheduleDetailDTO>
    {
        private readonly IMapper _mapper;
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleDetailQueryHandler(IMapper mapper,
        IScheduleRepository scheduleRepository)
        {
            _mapper = mapper;
            _scheduleRepository = scheduleRepository;
        }

        public async Task<ScheduleDetailDTO> Handle(GetDetailScheduleQuery request, CancellationToken cancellationToken)
        {
            var query = await _scheduleRepository.GetByIdAsync(request.ScheduleId);
            return _mapper.Map<ScheduleDetailDTO>(query);
        }
    }
}