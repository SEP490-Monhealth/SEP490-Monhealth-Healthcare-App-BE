using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommandHandler : IRequestHandler<CreateMetricCommand, Unit>
    {
        private readonly IMetricsCalculator _metricCalculator;
        private readonly IGoalsCalculator _goalCalculator;
        private readonly IMetricRepository _metricRepository;
        private readonly IGoalRepository _goalRepository;
        private readonly IMapper _mapper;
        public CreateMetricCommandHandler(
            IMetricRepository metricRepository, 
            IMapper mapper, 
            IMetricsCalculator metricCalculator, 
            IGoalRepository goalRepository, 
            IGoalsCalculator goalsCalculator)
        {
            _metricCalculator = metricCalculator;
            _metricRepository = metricRepository;
            _mapper = mapper;
            _goalRepository = goalRepository;
            _goalCalculator = goalsCalculator;
        }
        public async Task<Unit> Handle(CreateMetricCommand request, CancellationToken cancellationToken)
        {
            #region tinh toan Metric
            var newMetric = _mapper.Map<Monhealth.Domain.Metric>(request.CreateMetricDto);
            var age = DateTime.Now.Year - request.CreateMetricDto.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.CreateMetricDto.DateOfBirth.DayOfYear)
            {
                age--;
            }
            newMetric.Bmi = (float)_metricCalculator.CalculateBMI(request.CreateMetricDto.Weight, request.CreateMetricDto.Height);
            newMetric.Bmr = _metricCalculator.CalculateBMR(request.CreateMetricDto.Weight, request.CreateMetricDto.Height, age, request.CreateMetricDto.Gender);
            newMetric.Tdee = _metricCalculator.CalculateTDEE(newMetric.Bmr, request.CreateMetricDto.ActivityLevel);
            newMetric.Ibw = _metricCalculator.CalculateIBW(request.CreateMetricDto.Height, request.CreateMetricDto.Gender);

            newMetric.MetricId = Guid.NewGuid();
            newMetric.CreatedAt = DateTime.Now;
            newMetric.UpdatedAt = DateTime.Now;
            _metricRepository.Add(newMetric);
            #endregion

            #region tinh toan Goal
            var newGoal = _mapper.Map<Goal>(request.CreateMetricDto);          
            _goalCalculator.CreateCalculateGoal(newGoal, request.CreateMetricDto, newMetric.Tdee);
            newGoal.GoalId = newMetric.MetricId;
            newGoal.Status = GoalStatus.Active;
            newGoal.CreatedAt = DateTime.Now;
            newGoal.UpdatedAt = DateTime.Now;
            _goalRepository.Add(newGoal);
            await _goalRepository.SaveChangeAsync();
            
            #endregion
            return Unit.Value;
        }

    }
}

