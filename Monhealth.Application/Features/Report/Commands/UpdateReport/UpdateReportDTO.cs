namespace Monhealth.Application.Features.Report.Commands.UpdateReport
{
    public class UpdateReportDTO
    {
        public string Reason { get; set; }
        public List<string> ImageUrls { get; set; } = new();
    }
}
