namespace Monhealth.Application.Models.PayOS
{
    public class PayOSSettings
    {
        public string PAYOS_CLIENT_ID { get; set; }
        public string PAYOS_API_KEY { get; set; }
        public string PAYOS_CHECKSUM_KEY { get; set; }
        public string RETURN_URL { get; set; }
        public string CANCEL_URL { get; set; }
    }
}
