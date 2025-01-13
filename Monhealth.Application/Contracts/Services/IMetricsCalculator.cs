namespace Monhealth.Application.Contracts.Services
{
    public interface IMetricsCalculator
    {
        double CalculateBMI(double weight, double height);
        float CalculateBMR(float weight, float height, int age, string gender);
        float CalculateTDEE(float bmr, float activityLevel);
        float CalculateIBW(float height, string gender);
    }
}
