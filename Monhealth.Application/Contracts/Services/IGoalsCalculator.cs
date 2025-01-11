using Monhealth.Application.Features.Goals.Commands.UpdateCommand;
using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Application.Features.Metric.Commands.UpdateMetric;
using Monhealth.Domain;


namespace Monhealth.Application.Contracts.Services
{
    public interface IGoalsCalculator
    {
        void CreateCalculateGoal(Goal goal, CreateMetricDto createMetricDto, float tdee);
        void UpdateMetricCalculateGoal(Goal metricToUpdate, string goalType, float tdee, float weight, float activityLevel);
    }
}
