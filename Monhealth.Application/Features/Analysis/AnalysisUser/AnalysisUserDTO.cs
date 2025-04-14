namespace Monhealth.Application
{
    public class AnalysisUserDTO
    {
        public TotalUserDTO TotalUsers { get; set; } = new TotalUserDTO();
        public NewUserDTO NewUsers { get; set; } = new NewUserDTO();
        public TotalVisitDTO TotalVisits { get; set; } = new TotalVisitDTO();
        public ConversionRateDTO ConversionRate { get; set; } = new ConversionRateDTO();

    }
    public class TotalUserDTO
    {
        public int Count { get; set; }
        public float GrowthRate { get; set; }
    }
    public class NewUserDTO
    {
        public int Count { get; set; }
        public float GrowthRate { get; set; }
    }
    public class TotalVisitDTO
    {
        public int Count { get; set; }
        public float GrowthRate { get; set; }
    }
    public class ConversionRateDTO
    {
        public int Count { get; set; }
        public float GrowthRate { get; set; }
    }
}