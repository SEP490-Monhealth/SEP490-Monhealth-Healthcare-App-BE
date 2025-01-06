using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new Exception("Không tìm thấy thông tin TDEE cho người dùng.");
            }
            var newGoal = _mapper.Map<Monhealth.Domain.Goal>(request.CreateGoalDTO);
            // Tính CaloriesGoal dựa trên GoalType
            switch (request.CreateGoalDTO.GoalType)
            {
                case "WeightLoss":
                    if(newGoal.WeightGoal > infoUser.Weight)
                    {
                        throw new Exception("Mục tiêu giảm cân phải nhỏ hơn cân nặng hiện tại.");
                    }
                    var caloriesWeightLoss = infoUser.Tdee * 0.8f; // Giảm 20%
                    newGoal.CaloriesGoal = caloriesWeightLoss; 
                    newGoal.ProteinGoal = (caloriesWeightLoss * 0.4f);

                    var carbGoalWeightLoss = caloriesWeightLoss * 0.35f;
                    newGoal.CarbGoal = carbGoalWeightLoss;

                    newGoal.FatGoal = (caloriesWeightLoss * 0.25f);

                    newGoal.FiberGoal = carbGoalWeightLoss * 0.1f;
                    newGoal.SugarGoal = carbGoalWeightLoss * 0.25f;
                    break;
                case "MaintainWeight":
                    if (newGoal.WeightGoal < infoUser.Weight)
                    {
                        throw new Exception("Mục tiêu tăng cân phải lớn hơn cân nặng hiện tại.");
                    }
                    var caloriesMaintainWeight = infoUser.Tdee * 1.1f; // Tăng 10-15%
                    newGoal.CaloriesGoal = caloriesMaintainWeight; 
                    newGoal.ProteinGoal = (caloriesMaintainWeight * 0.3f);

                    var carbGoalMaintainWeight = caloriesMaintainWeight * 0.5f;
                    newGoal.CarbGoal = carbGoalMaintainWeight;

                    newGoal.FatGoal = (caloriesMaintainWeight * 0.2f);

                    newGoal.FiberGoal = carbGoalMaintainWeight * 0.1f;
                    newGoal.SugarGoal = carbGoalMaintainWeight * 0.25f;
                    break;
                case "WeightGain":
                    var caloriesWeightGain = infoUser.Tdee; // Giữ nguyên TDEE
                    newGoal.CaloriesGoal = caloriesWeightGain; 
                    newGoal.ProteinGoal = (caloriesWeightGain * 0.3f);

                    var carbGoalWeightGain = caloriesWeightGain * 0.4f;
                    newGoal.CarbGoal = carbGoalWeightGain;

                    newGoal.FatGoal = (caloriesWeightGain * 0.3f);

                    newGoal.FiberGoal = carbGoalWeightGain * 0.1f;
                    newGoal.SugarGoal = carbGoalWeightGain * 0.25f;
                    break;
                default:
                    throw new Exception("Loại mục tiêu không hợp lệ.");
            }
            // tinh WaterGoal
            if(infoUser.ActivityLevel == 1.2f || infoUser.ActivityLevel == 1.375f)
            {
                newGoal.WaterGoal = (int)infoUser.Weight * 30;
            } else
            {
                newGoal.WaterGoal = (int)infoUser.Weight * 40;
            }

            newGoal.GoalId = Guid.NewGuid();
            newGoal.Status = GoalStatus.Active;
            newGoal.CreatedAt = DateTime.Now;
            newGoal.UpdatedAt = DateTime.Now;
            _goalRepository.Add(newGoal);
            await _goalRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
