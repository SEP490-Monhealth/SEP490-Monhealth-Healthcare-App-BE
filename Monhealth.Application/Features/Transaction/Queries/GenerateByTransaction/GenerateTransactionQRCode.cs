using MediatR;
namespace Monhealth.Application
{
    public class GenerateTransactionQRCode : IRequest<ResponseForTransaction>
    {
        public Guid TransactionId { get; set; }
        public GenerateTransactionQRCode(Guid id)
        {
            TransactionId = id;
        }

    }
}