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
            _metricRepository.Update(metricToUpdate);
            await _metricRepository.SaveChangeAsync();
            return true;
        }
    }
}
