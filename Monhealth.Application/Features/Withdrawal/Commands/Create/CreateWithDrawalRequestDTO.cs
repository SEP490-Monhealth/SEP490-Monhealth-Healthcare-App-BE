using MediatR;

namespace Monhealth.Application
{
    public class CreateWithdrawalRequestDTO : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
        public Guid ConsultantBankId { get; set; }
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
    }
}