using MediatR;

namespace Monhealth.Application
{
    public class UserAllergyDTO
    {
        public List<string> Allergies { get; set; } = [];
    }
    public class UpdateUserAllergyRequest : IRequest<bool>
    {
        public Guid UserId { get; set; }
        public UserAllergyDTO Request { get; set; }
        public UpdateUserAllergyRequest( UserAllergyDTO request)
        {

            Request = request;
        }
    }

}