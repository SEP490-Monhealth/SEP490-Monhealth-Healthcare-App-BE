using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId
{
    public class GetWalletByConsultantIdDTO : TimeEntity
    {
        public Guid WalletId { get; set; }
        public float Balance { get; set; }
        public bool Status { get; set; }
    }
}
