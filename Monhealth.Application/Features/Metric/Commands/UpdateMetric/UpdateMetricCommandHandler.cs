using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Domain;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricCommandHandler : IRequestHandler<UpdateMetricCommand, bool>
    {
        private readonly IMetricsCalculator _metricCalculator;
        private readonly IGoalsCalculator _goalsCalculator;
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;

        public UpdateMetricCommandHandler(
            IMetricRepository metricRepository, 
            IMapper mapper, 
            IMetricsCalculator metricCalculator, 
            IGoalsCalculator goalsCalculator,
            IGoalRepository goalRepository)
        {
            _metricCalculator = metricCalculator;
            _goalsCalculator = goalsCalculator;
            _metricRepository = metricRepository;
            _goalRepository = goalRepository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateMetricCommand request, CancellationToken cancellationToken)
        {
            var metricToUpdate = await _metricRepository.GetByIdAsync(request.MetricId);
            if (metricToUpdate == null)
            {
                return false;
            }

            // Tinh tuoi tu DateOfBirth
            var age = DateTime.Now.Year - request.UpdateMetricDto.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.UpdateMetricDto.DateOfBirth.DayOfYear)
            {
                age--;
            }

            // De kiem tra co thay doi that su khong
            bool isUpdated = false;

            // Kiem tra và cap nhat BMI
            if (request.UpdateMetricDto.Height != metricToUpdate.Height || request.UpdateMetricDto.Weight != metricToUpdate.Weight)
            {
                metricToUpdate.Bmi = (float)_metricCalculator.CalculateBMI(request.UpdateMetricDto.Weight, request.UpdateMetricDto.Height);
                isUpdated = true;
            }

            // Kiem tra va cap nhat BMR
            if (request.UpdateMetricDto.Height != metricToUpdate.Height ||
                request.UpdateMetricDto.Weight != metricToUpdate.Weight ||
                request.UpdateMetricDto.DateOfBirth != metricToUpdate.DateOfBirth ||
                !string.Equals(request.UpdateMetricDto.Gender, metricToUpdate.Gender.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                metricToUpdate.Bmr = _metricCalculator.CalculateBMR(request.UpdateMetricDto.Weight, request.UpdateMetricDto.Height, age, request.UpdateMetricDto.Gender);
                isUpdated = true;
            }

            // Kiem tra va cap nhat TDEE
            if (request.UpdateMetricDto.ActivityLevel != metricToUpdate.ActivityLevel || isUpdated)
            {
                metricToUpdate.Tdee = _metricCalculator.CalculateTDEE(metricToUpdate.Bmr, request.UpdateMetricDto.ActivityLevel);
                isUpdated = true;
            }

            // Kiem tra va cap nhat IBW
            if (request.UpdateMetricDto.Height != metricToUpdate.Height ||
                !string.Equals(request.UpdateMetricDto.Gender, metricToUpdate.Gender.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                metricToUpdate.Ibw = _metricCalculator.CalculateIBW(request.UpdateMetricDto.Height, request.UpdateMetricDto.Gender);
                isUpdated = true;
            }
            // Cap nhat neu co bat ky thay doi nao
            if (isUpdated)
            {
                metricToUpdate.UpdatedAt = DateTime.Now;
                _mapper.Map(request.UpdateMetricDto, metricToUpdate);
                _metricRepository.Update(metricToUpdate);
                await _metricRepository.SaveChangeAsync();
            }
            #region Update Goal
            var goalToUpdate = await _goalRepository.GetByIdAsync(request.MetricId);
            if (goalToUpdate == null)
            {
                throw new Exception("Không tìm thấy mục tiêu.");
            }
            goalToUpdate.UpdatedAt = DateTime.Now;
            //_goalsCalculator.UpdateMetricCalculateGoal(goalToUpdate, goalToUpdate.GoalType.ToString(), metricToUpdate.Tdee, metricToUpdate.Weight);
            _goalsCalculator.UpdateMetricCalculateGoal(goalToUpdate, goalToUpdate.GoalType.ToString(), metricToUpdate.Tdee, metricToUpdate.Weight, metricToUpdate.ActivityLevel);
            _goalRepository.Update(goalToUpdate);
            await _goalRepository.SaveChangeAsync();
            #endregion
            return true;
        }
    }

}
