using MediatR;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class ScheduleCommand : IRequestHandler<ScheduleRequest, bool>
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleCommand(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task<bool> Handle(ScheduleRequest request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Domain.Schedule
            {
                  ConsultantId = request.ConsultantId,
                  CreatedAt = DateTime.Now,
                  UpdatedAt = DateTime.Now,
                  Date = request.Date,
                  Time = request.Time
            };
            _scheduleRepository.Add(model);
         await _scheduleRepository.SaveChangeAsync();
         return true;   
        }
    }
}