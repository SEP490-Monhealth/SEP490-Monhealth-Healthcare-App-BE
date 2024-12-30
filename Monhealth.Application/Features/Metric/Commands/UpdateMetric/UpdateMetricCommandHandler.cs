using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class UpdateMetricCommandHandler : IRequestHandler<UpdateMetricCommand, bool>
    {
        private readonly IMetricRepository _metricRepository;
        private readonly IMapper _mapper;

        public UpdateMetricCommandHandler(IMetricRepository metricRepository, IMapper mapper)
        {
            _metricRepository = metricRepository;
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
            var age = DateTime.Now.Year - request.MetricDto.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.MetricDto.DateOfBirth.DayOfYear)
            {
                age--;
            }

            // De kiem tra co thay doi that su khong
            bool isUpdated = false; 

            var metricsCalculate = new UpdateMetricsCalculate();

            // Kiem tra và cap nhat BMI
            if (request.MetricDto.Height != metricToUpdate.Height || request.MetricDto.Weight != metricToUpdate.Weight)
            {
                metricToUpdate.Bmi = (float)metricsCalculate.CalculateBMI(request.MetricDto.Weight, request.MetricDto.Height);
                isUpdated = true;
            }

            // Kiem tra va cap nhat BMR
            if (request.MetricDto.Height != metricToUpdate.Height ||
                request.MetricDto.Weight != metricToUpdate.Weight ||
                request.MetricDto.DateOfBirth != metricToUpdate.DateOfBirth ||
                !string.Equals(request.MetricDto.Gender, metricToUpdate.Gender.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                metricToUpdate.Bmr = metricsCalculate.CalculateBMR(request.MetricDto.Weight, request.MetricDto.Height, age, request.MetricDto.Gender);
                isUpdated = true;
            }

            // Kiem tra va cap nhat TDEE
            if (request.MetricDto.ActivityLevel != metricToUpdate.ActivityLevel || isUpdated)
            {
                metricToUpdate.Tdee = metricsCalculate.CalculateTDEE(metricToUpdate.Bmr, request.MetricDto.ActivityLevel);
                isUpdated = true;
            }

            // Kiem tra va cap nhat IBW
            if (request.MetricDto.Height != metricToUpdate.Height ||
                !string.Equals(request.MetricDto.Gender, metricToUpdate.Gender.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                metricToUpdate.Ibw = metricsCalculate.CalculateIBW(request.MetricDto.Height, request.MetricDto.Gender);
                isUpdated = true;
            }

            // Cap nhat neu co bat ky thay doi nao
            if (isUpdated)
            {
                metricToUpdate.UpdatedAt = DateTime.Now;
                _mapper.Map(request.MetricDto, metricToUpdate);
                _metricRepository.Update(metricToUpdate);
                await _metricRepository.SaveChangeAsync();
            }

            return isUpdated;
        }
    }

}
