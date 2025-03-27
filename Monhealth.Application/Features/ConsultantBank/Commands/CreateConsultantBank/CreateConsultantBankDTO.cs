namespace Monhealth.Application.Features.ConsultantBank.Commands.CreateConsultantBank
{
    public class CreateConsultantBankDTO
    {
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;

        public string BankName { get; set; } = string.Empty;

        public Guid ConsultantId { get; set; }
    }
}
