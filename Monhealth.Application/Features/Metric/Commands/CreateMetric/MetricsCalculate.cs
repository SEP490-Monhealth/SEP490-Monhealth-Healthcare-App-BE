namespace Monhealth.Application.Features.Metric.Commands.CreateMetric
{
    public class MetricsCalculate
    {
        public double CalculateBMI(double weight, double height)
        {
            return weight / Math.Pow((double)height / 100, 2); // Chiều cao được chuyển từ cm sang m
        }

        public float CalculateBMR(float weight, float height, int age, string gender)
        {
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return 10 * weight + 6.25f * height - 5 * age + 5;
            }
            return 10 * weight + 6.25f * height - 5 * age - 161;
        }

        public float CalculateTDEE(float bmr, float activityLevel)
        {
            return bmr * activityLevel;
        }

        public float CalculateIBW(float height, string gender)
        {
            if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
            {
                return 50 + 0.91f * (height - 152.4f);
            }
            return 45.5f + 0.91f * (height - 152.4f);
        }
    }
}
