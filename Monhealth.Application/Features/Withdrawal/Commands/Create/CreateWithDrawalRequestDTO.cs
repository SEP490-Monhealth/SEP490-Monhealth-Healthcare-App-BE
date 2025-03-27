using MediatR;

namespace Monhealth.Application
{
    public class CreateWithDrawalRequestDTO : IRequest<bool>
    {
        public Guid ConsultantId { get; set; }
        public string Description { get; set; } = string.Empty;
        public float Amount { get; set; }

    }
}