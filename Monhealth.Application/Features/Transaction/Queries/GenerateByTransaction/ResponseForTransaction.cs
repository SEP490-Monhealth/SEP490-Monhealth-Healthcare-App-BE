namespace Monhealth.Application
{
    public record ResponseForTransaction
    (
        string QrCodeUrl,
        string BankName,
        string AccountName,
        float Amount,
        string Description)
    {

    }
}