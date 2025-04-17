using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Reminders.Commands.UpdateReminderStatus
{
    public class UpdateReminderStatusCommandHandler : IRequestHandler<UpdateReminderStatusCommand, bool>
    {
        private readonly IWaterReminderRepository _reminderRepository;
        private readonly IDailyWaterIntakesRepository _dailyWaterIntakesRepository;

        public UpdateReminderStatusCommandHandler(IWaterReminderRepository reminderRepository,
        IDailyWaterIntakesRepository dailyWaterIntakesRepository)
        {
            _dailyWaterIntakesRepository = dailyWaterIntakesRepository;
            _reminderRepository = reminderRepository;
        }

        public async Task<bool> Handle(UpdateReminderStatusCommand request, CancellationToken cancellationToken)
        {
            var id = await _reminderRepository.GetByIdAsync(request.WaterReminderId);
            if (id == null) throw new Exception("lời nhắc không tồn tại");
            id.Status = !id.Status;
            DateTime today = DateTime.Now.Date;
            if (id.UserId == null)
            {
                throw new Exception("UserId is null");
            }
            _reminderRepository.Update(id);
            var existingWater = await _dailyWaterIntakesRepository.GetDailyWaterIntakeByUserAndDate(today, id.UserId.Value);
            if (existingWater != null)
            {
                if (id.Status == false)
                {
                    _dailyWaterIntakesRepository.Remove(existingWater);
                }
            }

            await _reminderRepository.SaveChangeAsync();
            return true;
        }
    }
}