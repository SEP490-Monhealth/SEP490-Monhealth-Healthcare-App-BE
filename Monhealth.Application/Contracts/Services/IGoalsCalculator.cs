using Monhealth.Application.Features.Metric.Commands.CreateMetric;
using Monhealth.Domain;


namespace Monhealth.Application.Contracts.Services
{
    public interface IGoalsCalculator
    {
        void CreateCalculateGoal(Goal goal, CreateMetricDTO createMetricDto, float tdee);
        void UpdateMetricCalculateGoal(Goal metricToUpdate, string goalType, float tdee, float weight, float activityLevel);
    }
}
