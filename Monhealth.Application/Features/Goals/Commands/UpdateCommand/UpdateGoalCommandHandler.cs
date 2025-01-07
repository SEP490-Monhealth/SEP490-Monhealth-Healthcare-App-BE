using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new Exception("Không tìm thấy mục tiêu.");
            }

            // Lấy TDEE từ Metric dựa trên UserId
            var infoMetricOfUser = await _metricRepository.GetMetricByMetricIdUserIdAsync(request.GoalId, existingGoal.UserId);
            if (infoMetricOfUser == null)
            {
                throw new Exception("Không tìm thấy thông tin TDEE cho người dùng.");
            }
            
            // Chuyen tu string sang enum
            if (!Enum.TryParse<GoalType>(request.UpdateGoalDTO.GoalType, true, out var parsedGoalType))
            {
                throw new Exception("Loại mục tiêu không hợp lệ.");
            }
            infoMetricOfUser.GoalType = parsedGoalType;
            infoMetricOfUser.WeightGoal = request.UpdateGoalDTO.WeightGoal;
            infoMetricOfUser.UpdatedAt = DateTime.Now;

            existingGoal.GoalType = parsedGoalType;
            existingGoal.WeightGoal = request.UpdateGoalDTO.WeightGoal;
            existingGoal.UpdatedAt = DateTime.Now;

            // Tính CaloriesGoal dựa trên GoalType
            switch (request.UpdateGoalDTO.GoalType)
            {
                case "WeightLoss":
                    if (existingGoal.WeightGoal > infoMetricOfUser.Weight)
                    {
                        throw new Exception($"Cân nặng hiện tại là {infoMetricOfUser.Weight}. Mục tiêu giảm cân phải nhỏ hơn cân nặng hiện tại.");
                    }
                    var caloriesWeightLoss = infoMetricOfUser.Tdee * 0.8f; // Giảm 20%
                    existingGoal.CaloriesGoal = caloriesWeightLoss;
                    existingGoal.ProteinGoal = (caloriesWeightLoss * 0.4f);

                    var carbGoalWeightLoss = caloriesWeightLoss * 0.35f;
                    existingGoal.CarbGoal = carbGoalWeightLoss;

                    existingGoal.FatGoal = (caloriesWeightLoss * 0.25f);

                    existingGoal.FiberGoal = carbGoalWeightLoss * 0.1f;
                    existingGoal.SugarGoal = carbGoalWeightLoss * 0.25f;
                    break;
                case "MaintainWeight":
                    if (existingGoal.WeightGoal < infoMetricOfUser.Weight)
                    {
                        throw new Exception($"Cân nặng hiện tại là {infoMetricOfUser.Weight}. Mục tiêu tăng cân phải lớn hơn cân nặng hiện tại.");
                    }
                    var caloriesMaintainWeight = infoMetricOfUser.Tdee * 1.1f; // Tăng 10-15%
                    existingGoal.CaloriesGoal = caloriesMaintainWeight;
                    existingGoal.ProteinGoal = (caloriesMaintainWeight * 0.3f);

                    var carbGoalMaintainWeight = caloriesMaintainWeight * 0.5f;
                    existingGoal.CarbGoal = carbGoalMaintainWeight;

                    existingGoal.FatGoal = (caloriesMaintainWeight * 0.2f);

                    existingGoal.FiberGoal = carbGoalMaintainWeight * 0.1f;
                    existingGoal.SugarGoal = carbGoalMaintainWeight * 0.25f;
                    break;
                case "WeightGain":
                    var caloriesWeightGain = infoMetricOfUser.Tdee; // Giữ nguyên TDEE
                    existingGoal.CaloriesGoal = caloriesWeightGain;
                    existingGoal.ProteinGoal = (caloriesWeightGain * 0.3f);

                    var carbGoalWeightGain = caloriesWeightGain * 0.4f;
                    existingGoal.CarbGoal = carbGoalWeightGain;

                    existingGoal.FatGoal = (caloriesWeightGain * 0.3f);

                    existingGoal.FiberGoal = carbGoalWeightGain * 0.1f;
                    existingGoal.SugarGoal = carbGoalWeightGain * 0.25f;
                    break;
                default:
                    throw new Exception("Loại mục tiêu không hợp lệ.");
            }
            // tinh WaterGoal
            if (infoMetricOfUser.ActivityLevel == 1.2f || infoMetricOfUser.ActivityLevel == 1.375f)
            {
                existingGoal.WaterGoal = (int)infoMetricOfUser.Weight * 30;
            }
            else
            {
                existingGoal.WaterGoal = (int)infoMetricOfUser.Weight * 40;
            }
            _goalRepository.Update(existingGoal);
            await _goalRepository.SaveChangeAsync();
            return true;
        }
    }
}
