namespace Monhealth.Application.Features.Report.Commands.CreateReport
{
    public class CreateReportDTO
    {
        public Guid BookingId { get; set; }
        public string Reason { get; set; }
        public List<string> ImageUrls { get; set; } = new();
    }
}
