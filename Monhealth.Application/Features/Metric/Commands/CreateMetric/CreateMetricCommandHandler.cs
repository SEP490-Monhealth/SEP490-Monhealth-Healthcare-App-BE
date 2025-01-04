using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;

namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class CreateMetricCommandHandler : IRequestHandler<CreateMetricCommand, Unit>
    {
        private readonly IMetricsCalculate _metricCalculate;
        private readonly IMetricRepository _metricRepository;
        private readonly IMapper _mapper;
        public CreateMetricCommandHandler(IMetricRepository metricRepository, IMapper mapper, IMetricsCalculate metricCalculate)
        private readonly IGenerateDailyMenuService _generateDailyMenuService;
        private readonly IDailyMealRepository _dailyMealRepository;
        public CreateMetricCommandHandler(IMetricRepository metricRepository, IMapper mapper, IGenerateDailyMenuService generateDailyMenuService, IDailyMealRepository dailyMealRepository)
        {
            _metricCalculate = metricCalculate;
            _metricRepository = metricRepository;
            _mapper = mapper;
            _generateDailyMenuService = generateDailyMenuService;
            _dailyMealRepository = dailyMealRepository;
        }
        public async Task<Unit> Handle(CreateMetricCommand request, CancellationToken cancellationToken)
        {


            var newMetric = _mapper.Map<Monhealth.Domain.Metric>(request.CreateMetricDto);

            // tinh tuoi tu DateOfBirth
            var age = DateTime.Now.Year - request.CreateMetricDto.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.CreateMetricDto.DateOfBirth.DayOfYear)
            {
                var newMetric = _mapper.Map<Monhealth.Domain.Metric>(request.CreateMetricDto);

                // tinh tuoi tu DateOfBirth
                var age = DateTime.Now.Year - request.CreateMetricDto.DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < request.CreateMetricDto.DateOfBirth.DayOfYear)
                {
                    age--;
                }

                // tinh toan BMI, BMR, TDEE, IBW
                var weight = request.CreateMetricDto.Weight;
                var height = request.CreateMetricDto.Height;
                var gender = request.CreateMetricDto.Gender;
                var activityLevel = request.CreateMetricDto.ActivityLevel;

                // tinh BMI
                newMetric.Bmi = (float)_metricCalculate.CalculateBMI(weight, height);

                // tinh BMR
                var bmr = _metricCalculate.CalculateBMR(weight, height, age, gender);
                newMetric.Bmr = bmr;

                // tinh TDEE
                newMetric.Tdee = _metricCalculate.CalculateTDEE(bmr, activityLevel);

                // tinh IBW
                newMetric.Ibw = _metricCalculate.CalculateIBW(height, gender);


                // new metricId
                newMetric.MetricId = Guid.NewGuid();
                newMetric.CreatedAt = DateTime.Now;
                newMetric.UpdatedAt = DateTime.Now;

                _metricRepository.Add(newMetric);
                await _metricRepository.SaveChangeAsync();
                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi create " + ex.Message);
            }
                age--;
            }

            // tinh toan BMI, BMR, TDEE, IBW
            var calculator = new MetricsCalculate();
            var weight = request.CreateMetricDto.Weight;
            var height = request.CreateMetricDto.Height;
            var gender = request.CreateMetricDto.Gender;
            var activityLevel = request.CreateMetricDto.ActivityLevel;

            // tinh BMI
            newMetric.Bmi = (float)calculator.CalculateBMI(weight, height);

            // tinh BMR
            var bmr = calculator.CalculateBMR(weight, height, age, gender);
            newMetric.Bmr = bmr;

            // tinh TDEE
            newMetric.Tdee = calculator.CalculateTDEE(bmr, activityLevel);

            // tinh IBW
            newMetric.Ibw = calculator.CalculateIBW(height, gender);


            // new metricId
            newMetric.MetricId = Guid.NewGuid();
            newMetric.CreatedAt = DateTime.Now;
            newMetric.UpdatedAt = DateTime.Now;

            _metricRepository.Add(newMetric);

            var dailyMeal = await _generateDailyMenuService.GenerateDailyMealAsync(request.CreateMetricDto.UserId, newMetric.Tdee, "lose");
            _dailyMealRepository.Add(dailyMeal);

            await _metricRepository.SaveChangeAsync();



            return Unit.Value;



        }
    }
}
