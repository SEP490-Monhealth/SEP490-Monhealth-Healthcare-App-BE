using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminder
{
    public class UpdateReminderCommandHandler : IRequestHandler<UpdateReminderCommand, bool>
    {
        private readonly IReminderRepository _reminderRepository;

        public UpdateReminderCommandHandler(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public async Task<bool> Handle(UpdateReminderCommand request, CancellationToken cancellationToken)
        {
            var id = await _reminderRepository.GetByIdAsync(request.WaterReminderId);
            if (id == null) throw new Exception("Id không tồn tại");
            id.Volume = request.Volume;
            id.Time = request.Time;
            id.WaterReminderName = request.WaterReminderName;
            _reminderRepository.Update(id);
            await _reminderRepository.SaveChangeAsync();
            return true;
        }
    }
}