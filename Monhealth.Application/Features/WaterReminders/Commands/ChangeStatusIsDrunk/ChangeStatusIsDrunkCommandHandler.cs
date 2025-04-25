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
            if (waterRemind == null)
                throw new NotFoundException("Water reminder không tồn tại.");

            
            if (waterRemind.Status != true)
                throw new BadRequestException("Status phải là true mới được đổi nha bé <3.");

            
            bool wasDrunk = waterRemind.IsDrunk ;
            waterRemind.IsDrunk = !wasDrunk;

            
            _waterReminderRepository.Update(waterRemind);
            await _waterReminderRepository.SaveChangeAsync();

            // Kiểm tra UserId có tồn tại
            if (!waterRemind.UserId.HasValue)
                throw new BadRequestException("UserId không được phép null.");

            var userId = waterRemind.UserId.Value;

            // Lấy Goal của User
            var goal = await _goalRepository.GetByUserIdAsync(userId);
            if (goal == null)
                throw new NotFoundException("Goal không tồn tại.");

            // Lấy hoặc tạo bản ghi DailyWaterIntake
            var today = DateTime.Now.Date;
            var existingWater = await _dailyWaterIntakesRepository.GetDailyWaterIntakeByUserAndDate(today, userId);

            if (existingWater == null)
            {
                existingWater = new Monhealth.Domain.DailyWaterIntake
                {
                    GoalId = goal.GoalId,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    TotalVolume = 0,
                    UserId = userId
                };
                _dailyWaterIntakesRepository.Add(existingWater);
                await _dailyWaterIntakesRepository.SaveChangeAsync();
            }

            // Cập nhật TotalVolume trong DailyWaterIntake
            if (waterRemind.IsDrunk == true)
            {
                existingWater.TotalVolume += waterRemind.Volume;
            }
            else if (waterRemind.IsDrunk == false)
            {
                existingWater.TotalVolume -= waterRemind.Volume;
            }

            existingWater.UpdatedAt = DateTime.Now;

            // Cập nhật bản ghi DailyWaterIntake
            _dailyWaterIntakesRepository.Update(existingWater);
            await _dailyWaterIntakesRepository.SaveChangeAsync();

            return true;
        }



    }
}
