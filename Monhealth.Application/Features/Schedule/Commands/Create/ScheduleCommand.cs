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
            if (request.Items != null)
            {
                foreach (var item in request.Items)
                {
                    var schedule = new Domain.Schedule
                    {
                        //ConsultantId = request.ConsultantId,
                        //Date = item.Date,
                        //Time = item.Time,
                        //Status = Domain.Enum.ScheduleStatus.Available,
                        //CreatedAt = DateTime.Now
                    };
                    _scheduleRepository.Add(schedule);
                }

                await _scheduleRepository.SaveChangeAsync();
            }
            return true;
        }
    }
}