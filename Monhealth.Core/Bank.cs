using Monhealth.Domain.Common;

namespace Monhealth.Domain
{
    public class Bank : BaseEntity
    {
        public Guid BankId { get; set; }
        public string BankCode { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public bool Status { get; set; }

        public ICollection<ConsultantBank> ConsultantBanks { get; set; }
    }
}
