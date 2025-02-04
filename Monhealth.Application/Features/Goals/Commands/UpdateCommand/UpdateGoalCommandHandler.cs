using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;


namespace Monhealth.Application.Features.Goals.Commands.UpdateCommand
{
    public class UpdateGoalCommandHandler : IRequestHandler<UpdateGoalCommand, bool>
    {
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public UpdateGoalCommandHandler(IGoalRepository goalRepository, IMapper mapper, IMetricRepository metricRepository)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
            _metricRepository = metricRepository;
        }
        public async Task<bool> Handle(UpdateGoalCommand request, CancellationToken cancellationToken)
        {
            var existingGoal = await _goalRepository.GetByIdAsync(request.GoalId);
            if (existingGoal == null)
            {
                throw new Exception("Không tìm thấy mục tiêu");
            }

            // Lấy TDEE từ Metric dựa trên UserId
            var infoMetricOfUser = await _metricRepository.GetMetricByMetricIdUserIdAsync(request.GoalId, existingGoal.UserId);
            if (infoMetricOfUser == null)
            {
                throw new Exception("Không tìm thấy thông tin TDEE cho người dùng");
            }

            // Chuyen tu string sang enum
            if (!Enum.TryParse<GoalType>(request.UpdateGoalDTO.GoalType, true, out var parsedGoalType))
            {
                throw new Exception("Loại mục tiêu không hợp lệ");
            }

            existingGoal.GoalType = parsedGoalType;
            existingGoal.WeightGoal = request.UpdateGoalDTO.WeightGoal;
            existingGoal.UpdatedAt = DateTime.Now;

            // Tính CaloriesGoal dựa trên GoalType
            switch (request.UpdateGoalDTO.GoalType)
            {
                case "WeightLoss":
                    if (existingGoal.WeightGoal > infoMetricOfUser.Weight)
                    {
                        throw new Exception($"Cân nặng hiện tại là {infoMetricOfUser.Weight}. Mục tiêu giảm cân phải nhỏ hơn cân nặng hiện tại");
                    }
                    var caloriesWeightLoss = infoMetricOfUser.Tdee * 0.8f; // Giảm 20%
                    existingGoal.CaloriesGoal = caloriesWeightLoss;
                    existingGoal.ProteinGoal = (caloriesWeightLoss * 0.4f);

                    var carbsGoalWeightLoss = caloriesWeightLoss * 0.35f;
                    existingGoal.CarbsGoal = carbsGoalWeightLoss;

                    existingGoal.FatGoal = (caloriesWeightLoss * 0.25f);

                    existingGoal.FiberGoal = carbsGoalWeightLoss * 0.1f;
                    existingGoal.SugarGoal = carbsGoalWeightLoss * 0.25f;
                    break;
                case "MaintainWeight":
                    if (existingGoal.WeightGoal < infoMetricOfUser.Weight)
                    {
                        throw new Exception($"Cân nặng hiện tại là {infoMetricOfUser.Weight}. Mục tiêu tăng cân phải lớn hơn cân nặng hiện tại");
                    }
                    var caloriesMaintainWeight = infoMetricOfUser.Tdee * 1.1f; // Tăng 10-15%
                    existingGoal.CaloriesGoal = caloriesMaintainWeight;
                    existingGoal.ProteinGoal = (caloriesMaintainWeight * 0.3f);

                    var carbsGoalMaintainWeight = caloriesMaintainWeight * 0.5f;
                    existingGoal.CarbsGoal = carbsGoalMaintainWeight;

                    existingGoal.FatGoal = (caloriesMaintainWeight * 0.2f);

                    existingGoal.FiberGoal = carbsGoalMaintainWeight * 0.1f;
                    existingGoal.SugarGoal = carbsGoalMaintainWeight * 0.25f;
                    break;
                case "WeightGain":
                    var caloriesWeightGain = infoMetricOfUser.Tdee; // Giữ nguyên TDEE
                    existingGoal.CaloriesGoal = caloriesWeightGain;
                    existingGoal.ProteinGoal = (caloriesWeightGain * 0.3f);

                    var carbsGoalWeightGain = caloriesWeightGain * 0.4f;
                    existingGoal.CarbsGoal = carbsGoalWeightGain;

                    existingGoal.FatGoal = (caloriesWeightGain * 0.3f);

                    existingGoal.FiberGoal = carbsGoalWeightGain * 0.1f;
                    existingGoal.SugarGoal = carbsGoalWeightGain * 0.25f;
                    break;
                default:
                    throw new Exception("Loại mục tiêu không hợp lệ");
            }
            // tinh WaterIntakesGoal
            if (infoMetricOfUser.ActivityLevel == 1.2f || infoMetricOfUser.ActivityLevel == 1.375f)
            {
                existingGoal.WaterIntakesGoal = (int)infoMetricOfUser.Weight * 30;
            }
            else
            {
                existingGoal.WaterIntakesGoal = (int)infoMetricOfUser.Weight * 40;
            }
            _goalRepository.Update(existingGoal);
            await _goalRepository.SaveChangeAsync();
            return true;
        }
    }
}
