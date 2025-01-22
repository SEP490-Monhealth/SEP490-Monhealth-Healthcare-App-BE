using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Schedule.Commands.Delete
{
    public class ScheduleCommandHandler : IRequestHandler<DeleteScheduleRequest, bool>
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleCommandHandler(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task<bool> Handle(DeleteScheduleRequest request, CancellationToken cancellationToken)
        {
            var id = await _scheduleRepository.GetByIdAsync(request.ScheduleId);
            _scheduleRepository.Remove(id);
            await _scheduleRepository.SaveChangeAsync();
            return true;
        }
    }
}