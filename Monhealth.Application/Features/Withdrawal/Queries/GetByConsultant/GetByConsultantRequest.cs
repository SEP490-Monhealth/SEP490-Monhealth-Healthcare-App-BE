using MediatR;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public record GetByConsultantDTO(Guid WithDrawalRequestId,
    Guid ConsultantId, ConsultantDTO1 Consultant, string Description,
    float Amount, WithdrawalStatus Status, DateTime? CreateAt, DateTime? UpdatedAt, Guid? CreatedBy, Guid? UpdatedBy);

    public class GetByConsultantRequest : IRequest<PageResult<GetByConsultantDTO>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetByConsultantRequest(Guid consultant, int page, int limit)
        {
            ConsultantId = consultant;
            Page = page;
            Limit = limit;
        }
    }

}
public class ConsultantDTO1
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string AvatarUrl { get; set; } = string.Empty;
}
