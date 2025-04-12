using MediatR;

namespace Monhealth.Application
{
    public class CreateUserAllergyRequest : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public List<string> Allergies { get; set; } = [];
    }
}