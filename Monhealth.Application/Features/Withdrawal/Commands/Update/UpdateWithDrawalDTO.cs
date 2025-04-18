using MediatR;

namespace Monhealth.Application
{
    public class UpdateWithdrawalDTO : IRequest<Boolean>
    {
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }
    }
}