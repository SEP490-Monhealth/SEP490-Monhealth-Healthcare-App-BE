namespace Monhealth.Application
{
    public class UpdateWithdrawalDTO
    {
        public Guid ConsultantBankId { get; set; }
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
    }
}