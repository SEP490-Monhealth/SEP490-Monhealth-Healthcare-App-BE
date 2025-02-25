using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class ScheduleCommand : IRequestHandler<ScheduleRequest, bool>
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMapper mapper;

        public ScheduleCommand(IScheduleRepository scheduleRepository, IMapper mapper)
        {
            _scheduleRepository = scheduleRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(ScheduleRequest request, CancellationToken cancellationToken)
        {
            var schedule = mapper.Map<Domain.Schedule>(request);
            schedule.Status = Domain.Enum.ScheduleStatus.Available;
            schedule.CreatedAt = DateTime.Now;
            _scheduleRepository.Add(schedule);
            await _scheduleRepository.SaveChangeAsync();
            return true;
        }
    }
}