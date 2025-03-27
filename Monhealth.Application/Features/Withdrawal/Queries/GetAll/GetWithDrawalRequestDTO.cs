using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetWithDrawalRequestDTO : BaseEntity
    {
        public Guid WithDrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public WithDrawalStatus Status { get; set; }
    }
}