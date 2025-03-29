namespace Monhealth.Application
{
    public record Response
   (
        string QrCodeUrl,
        string BankName,
        string AccountName,
        float Amount,
        string Description)
    {

    }
}