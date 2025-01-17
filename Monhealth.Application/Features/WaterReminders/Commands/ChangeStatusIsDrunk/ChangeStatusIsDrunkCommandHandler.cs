using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.WaterReminders.Commands.ChangeStatusIsDrunk
{
    public class ChangeStatusIsDrunkCommandHandler : IRequestHandler<ChangeStatusIsDrunkCommand, bool>
    {
        private readonly IWaterReminderRepository _waterReminderRepository;
        public ChangeStatusIsDrunkCommandHandler(IWaterReminderRepository waterReminderRepository)
        {
            _waterReminderRepository = waterReminderRepository;
        }

        public async Task<bool> Handle(ChangeStatusIsDrunkCommand request, CancellationToken cancellationToken)
        {
            var waterRemind = await _waterReminderRepository.GetByIdAsync(request.WaterReminderId);
            waterRemind.IsDrunk = !waterRemind.IsDrunk;
            _waterReminderRepository.Update(waterRemind);
            await _waterReminderRepository.SaveChangeAsync();
            return true; 
        }
    }
}