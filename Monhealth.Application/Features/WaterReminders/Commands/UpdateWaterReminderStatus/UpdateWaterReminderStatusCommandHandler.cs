using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminderStatus
{
    public class UpdateReminderStatusCommandHandler : IRequestHandler<UpdateReminderStatusCommand, bool>
    {
        private readonly IWaterReminderRepository _reminderRepository;

        public UpdateReminderStatusCommandHandler(IWaterReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public async Task<bool> Handle(UpdateReminderStatusCommand request, CancellationToken cancellationToken)
        {
            var id = await _reminderRepository.GetByIdAsync(request.WaterReminderId);
            if (id == null) throw new Exception("lời nhắc không tồn tại");
            id.Status = !id.Status;
            _reminderRepository.Update(id);
            await _reminderRepository.SaveChangeAsync();
            return true;
        }
    }
}