using Monhealth.Application.Contracts.Services;

namespace Monhealth.Application.Features.Metric.Commands.UpdateMetric
{
    public class MetricsCalculator : IMetricsCalculator
    {
        private const float MALE_BMR_CONSTANT = 5;
        private const float FEMALE_BMR_CONSTANT = -161;
        private const float IBW_BASE_HEIGHT = 152.4f; // Chiều cao gốc để tính IBW
        private const float IBW_MULTIPLIER = 0.91f;

        public float CalculateBMI(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
                throw new ArgumentException("Cân nặng và chiều cao phải lớn hơn 0");

            return weight / (float)Math.Pow(height / 100, 2); // Chuyển chiều cao từ cm sang m
        }

        public float CalculateBMR(float weight, float height, int age, string gender)
        {
            if (weight <= 0 || height <= 0 || age <= 0)
                throw new ArgumentException("Cân nặng, chiều cao và tuổi phải lớn hơn 0");

            float genderConstant = gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ? MALE_BMR_CONSTANT : FEMALE_BMR_CONSTANT;

            return 10 * weight + 6.25f * height - 5 * age + genderConstant;
        }

        public float CalculateTDEE(float bmr, float activityLevel)
        {
            if (bmr <= 0 || activityLevel <= 0)
                throw new ArgumentException("BMR và mức độ hoạt động phải lớn hơn 0");

            return bmr * activityLevel;
        }

        public float CalculateIBW(float height, string gender)
        {
            if (height <= 0)
                throw new ArgumentException("Chiều cao phải lớn hơn 0");

            float baseWeight = gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ? 50 : 45.5f;
            return baseWeight + IBW_MULTIPLIER * (height - IBW_BASE_HEIGHT);
        }
    }
}
