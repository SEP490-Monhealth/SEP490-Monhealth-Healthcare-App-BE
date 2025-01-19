using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
namespace Monhealth.Application.Features.WaterReminders.Commands.ChangeStatusIsDrunk
{
    public class ChangeStatusIsDrunkCommandHandler : IRequestHandler<ChangeStatusIsDrunkCommand, bool>
    {
        private readonly IWaterReminderRepository _waterReminderRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IDailyWaterIntakesRepository _dailyWaterIntakesRepository;
        public ChangeStatusIsDrunkCommandHandler(IWaterReminderRepository waterReminderRepository,
         IGoalRepository goalRepository,
        IDailyWaterIntakesRepository dailyWaterIntakesRepository)
        {
            _waterReminderRepository = waterReminderRepository;
            _dailyWaterIntakesRepository = dailyWaterIntakesRepository;
            _goalRepository = goalRepository;
        }

        public async Task<bool> Handle(ChangeStatusIsDrunkCommand request, CancellationToken cancellationToken)
        {
            var waterRemind = await _waterReminderRepository.GetByIdAsync(request.WaterReminderId);
            if (waterRemind.Status == true)
            {
                waterRemind.IsDrunk = !waterRemind.IsDrunk;
                _waterReminderRepository.Update(waterRemind);
                await _waterReminderRepository.SaveChangeAsync();
            }
            else
            {
                throw new BadRequestException("Status phải là true mới được đổi nha bé <3.");
            }
            if (waterRemind.UserId.HasValue)
            {
                var goal = await _goalRepository.GetByUserIdAsync(waterRemind.UserId.Value);
                var water = await _waterReminderRepository.GetReminderByUser(waterRemind.UserId.Value);

                if (water != null && waterRemind.IsDrunk == true)
                {
                    var totalVolume = water.Where(x => x.IsDrunk == true).Sum(x => x.Volume);
                    var model1 = new Monhealth.Domain.DailyWaterIntake
                    {
                        GoalId = goal.GoalId,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        TotalVolume = totalVolume,
                        UserId = waterRemind.UserId.Value
                    };
                    _dailyWaterIntakesRepository.Add(model1);
                    await _dailyWaterIntakesRepository.SaveChangeAsync();
                }
            }
            return true;
        }
    }
}