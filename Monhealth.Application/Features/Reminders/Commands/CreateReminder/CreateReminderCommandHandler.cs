using MediatR;
using Monhealth.Application.Contracts.Persistence;
namespace Monhealth.Application.Features.Reminder.Commands.CreateReminder
{
    public class CreateReminderCommandHandler : IRequestHandler<CreateReminderCommand, Unit>
    {
        private readonly IReminderRepository _reminderRepository;

        public CreateReminderCommandHandler(IReminderRepository reminderRepository)
        {
            _reminderRepository = reminderRepository;
        }

        public async Task<Unit> Handle(CreateReminderCommand request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Core.Reminder
            {
                UserId = request.UserId,
                ReminderName = request.ReminderName,
                Time = request.Time,
                Volume = request.Volume,
                Status = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _reminderRepository.Add(model);
            await _reminderRepository.SaveChangeAsync();
            return Unit.Value;

        }
    }
}