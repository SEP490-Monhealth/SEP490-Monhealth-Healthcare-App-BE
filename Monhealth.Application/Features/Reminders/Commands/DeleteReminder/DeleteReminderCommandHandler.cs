using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Commands.DeleteReminder
{
    public class DeleteReminderCommandHandler : IRequestHandler<DeleteReminderCommand, bool>
    {
        private readonly IReminderRepository _reminderRepository;

        public DeleteReminderCommandHandler(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public async Task<bool> Handle(DeleteReminderCommand request, CancellationToken cancellationToken)
        {
            var id = await _reminderRepository.GetByIdAsync(request.RemindId);
            if (id == null) throw new Exception("lời nhắc không tồn tại,");
            _reminderRepository.Remove(id);
            await _reminderRepository.SaveChangeAsync();
            return true;
        }
    }
}