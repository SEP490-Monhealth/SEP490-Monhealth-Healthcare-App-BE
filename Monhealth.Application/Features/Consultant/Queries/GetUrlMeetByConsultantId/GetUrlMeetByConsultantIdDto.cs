namespace Monhealth.Application.Features.Consultant.Queries.GetUrlMeetByConsultantId
{
    public class GetUrlMeetByConsultantIdDto
    {
        public Guid ConsultantId { get; set; }
        public string MeetUrl { get; set; } = string.Empty;
    }
}
