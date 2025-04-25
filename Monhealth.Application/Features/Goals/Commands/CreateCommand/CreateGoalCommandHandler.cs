using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Goals.Commands.CreateCommand
{
    public class CreateGoalCommandHandler : IRequestHandler<CreateGoalCommand, Unit>
    {
        private readonly IGoalRepository _goalRepository;
        private readonly IMetricRepository _metricRepository;
        private readonly IMapper _mapper;
        public CreateGoalCommandHandler(IGoalRepository goalRepository, IMapper mapper, IMetricRepository metricRepository)
        {
            _goalRepository = goalRepository;
            _mapper = mapper;
            _metricRepository = metricRepository;
        }
        public async Task<Unit> Handle(CreateGoalCommand request, CancellationToken cancellationToken)
        {
            // Lấy TDEE từ Metric dựa trên UserId
            var infoUser = await _metricRepository.GetMetricByUserIdAsync(request.CreateGoalDTO.UserId);
            if(infoUser == null)
            {
                throw new Exception("Không tìm thấy thông tin TDEE cho người dùng");
            }
            var newGoal = _mapper.Map<Monhealth.Domain.Goal>(request.CreateGoalDTO);
            // Tính CaloriesGoal dựa trên GoalType
            //switch (request.CreateGoalDTO.GoalType)
            //{
            //    case "WeightLoss":
            //        if(newGoal.WeightGoal > infoUser.Weight)
            //        {
            //            throw new Exception($"Cân nặng hiện tại là {infoUser.Weight}. Mục tiêu giảm cân phải nhỏ hơn cân nặng hiện tại");
            //        }
            //        var caloriesWeightLoss = infoUser.Tdee * 0.8f; // Giảm 20%
            //        newGoal.CaloriesGoal = caloriesWeightLoss; 
            //        newGoal.ProteinGoal = (caloriesWeightLoss * 0.4f);

            //        var carbsGoalWeightLoss = caloriesWeightLoss * 0.35f;
            //        newGoal.CarbsGoal = carbsGoalWeightLoss;

            //        newGoal.FatGoal = (caloriesWeightLoss * 0.25f);

            //        newGoal.FiberGoal = carbsGoalWeightLoss * 0.1f;
            //        newGoal.SugarGoal = carbsGoalWeightLoss * 0.25f;
            //        break;
            //    case "MaintainWeight":
            //        if (newGoal.WeightGoal < infoUser.Weight)
            //        {
            //            throw new Exception("Mục tiêu tăng cân phải lớn hơn cân nặng hiện tại");
            //        }
            //        var caloriesMaintainWeight = infoUser.Tdee * 1.1f; // Tăng 10-15%
            //        newGoal.CaloriesGoal = caloriesMaintainWeight; 
            //        newGoal.ProteinGoal = (caloriesMaintainWeight * 0.3f);

            //        var carbsGoalMaintainWeight = caloriesMaintainWeight * 0.5f;
            //        newGoal.CarbsGoal = carbsGoalMaintainWeight;

            //        newGoal.FatGoal = (caloriesMaintainWeight * 0.2f);

            //        newGoal.FiberGoal = carbsGoalMaintainWeight * 0.1f;
            //        newGoal.SugarGoal = carbsGoalMaintainWeight * 0.25f;
            //        break;
            //    case "WeightGain":
            //        var caloriesWeightGain = infoUser.Tdee; // Giữ nguyên TDEE
            //        newGoal.CaloriesGoal = caloriesWeightGain; 
            //        newGoal.ProteinGoal = (caloriesWeightGain * 0.3f);

            //        var carbsGoalWeightGain = caloriesWeightGain * 0.4f;
            //        newGoal.CarbsGoal = carbsGoalWeightGain;

            //        newGoal.FatGoal = (caloriesWeightGain * 0.3f);

            //        newGoal.FiberGoal = carbsGoalWeightGain * 0.1f;
            //        newGoal.SugarGoal = carbsGoalWeightGain * 0.25f;
            //        break;
            //    default:
            //        throw new Exception("Loại mục tiêu không hợp lệ");
            //}
            //// tinh WaterIntakesGoal
            //if(infoUser.ActivityLevel == 1.2f || infoUser.ActivityLevel == 1.375f)
            //{
            //    newGoal.WaterIntakesGoal = (int)infoUser.Weight * 30;
            //} else
            //{
            //    newGoal.WaterIntakesGoal = (int)infoUser.Weight * 40;
            //}

            newGoal.GoalId = Guid.NewGuid();
            newGoal.Status = GoalStatus.Active;
            newGoal.CreatedAt = DateTime.UtcNow;
            newGoal.UpdatedAt = DateTime.UtcNow;
            _goalRepository.Add(newGoal);
            await _goalRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
