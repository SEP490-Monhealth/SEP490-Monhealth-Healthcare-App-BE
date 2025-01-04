using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Services
{
    public interface IMetricsCalculate
    {
        double CalculateBMI(double weight, double height);
        float CalculateBMR(float weight, float height, int age, string gender);
        float CalculateTDEE(float bmr, float activityLevel);
        float CalculateIBW(float height, string gender);
    }
}
