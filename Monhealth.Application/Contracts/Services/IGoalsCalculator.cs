using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Services
{
    public interface IGoalsCalculator
    {
        void CalculateGoal(Goal goal, CreateMetricDto createMetricDto, float tdee);
    }
}
