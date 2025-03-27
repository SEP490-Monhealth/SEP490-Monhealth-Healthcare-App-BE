using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class WithDrawalRequest : BaseEntity
    {
        public Guid WithDrawalRequestId { get; set; }
        public Guid ConsultantId { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public WithDrawalStatus Status { get; set; }
        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
    }
}
