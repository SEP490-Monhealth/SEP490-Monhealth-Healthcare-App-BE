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
            metricToUpdate.UpdatedAt = DateTime.Now;
            // map DTO to entity
            _mapper.Map(request.MetricDto, metricToUpdate);

            // tinh tuoi tu DateOfBirth
            var age = DateTime.Now.Year - request.MetricDto.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < request.MetricDto.DateOfBirth.DayOfYear)
            {
                age--;
            }

            // kiem tra va cap nhat cac gia tri bmi, bmr, tdee, ibw
            if (request.MetricDto.DateOfBirth != metricToUpdate.DateOfBirth ||
                request.MetricDto.Gender != metricToUpdate.Gender.ToString() ||
                request.MetricDto.Height != metricToUpdate.Height ||
                request.MetricDto.Weight != metricToUpdate.Weight ||
                request.MetricDto.ActivityLevel != metricToUpdate.ActivityLevel)
            {
                var metricsCalculate = new UpdateMetricsCalculate();
                // tinh lai bmi
                metricToUpdate.Bmi = (float)metricsCalculate.CalculateBMI(request.MetricDto.Weight, request.MetricDto.Height);

                // tinh lai bmr
                metricToUpdate.Bmr = metricsCalculate.CalculateBMR(request.MetricDto.Weight, request.MetricDto.Height, age, request.MetricDto.Gender);

                // tinh lai tdee
                metricToUpdate.Tdee = metricsCalculate.CalculateTDEE(metricToUpdate.Bmr, request.MetricDto.ActivityLevel);

                // tinh lai ibw
                metricToUpdate.Ibw = metricsCalculate.CalculateIBW(request.MetricDto.Height, request.MetricDto.Gender);
            }

            _metricRepository.Update(metricToUpdate);
            await _metricRepository.SaveChangeAsync();
            return true;
        }
    }
}
