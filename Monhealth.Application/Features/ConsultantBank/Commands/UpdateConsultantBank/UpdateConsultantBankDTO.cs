namespace Monhealth.Application.Features.ConsultantBank.Commands.UpdateConsultantBank
{
    public class UpdateConsultantBankDTO
    {
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountName { get; set; } = string.Empty;

        public string BankName { get; set; } = string.Empty;
    }
}
