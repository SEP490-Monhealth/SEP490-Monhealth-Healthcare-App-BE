using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Bank.Queries.GetAllBanks
{
    public class GetAllBanksDTO : TimeEntity
    {
        public Guid BankId { get; set; }
        public string BankCode { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string ShortName { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
