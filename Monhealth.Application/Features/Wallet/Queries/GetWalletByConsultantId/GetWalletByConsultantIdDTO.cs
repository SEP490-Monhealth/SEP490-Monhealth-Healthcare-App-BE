namespace Monhealth.Application.Features.Wallet.Queries.GetWalletByConsultantId
{
    public class GetWalletByConsultantIdDTO
    {
        public Guid WalletId { get; set; }
        public float Balance { get; set; }
        public bool Status { get; set; }
    }
}
