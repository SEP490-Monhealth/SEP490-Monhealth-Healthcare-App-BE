using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Wallet.Queries.GetWalletById
{
    public class GetWalletByIdDTO : TimeEntity
    {
        public Guid ConsultantId { get; set; }
        public float Balance { get; set; }
        public bool Status { get; set; }
    }
}
