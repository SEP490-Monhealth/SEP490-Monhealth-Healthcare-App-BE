using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodDto : TimeEntity
    {
        public List<string> Categories { get; set; }
        public List<string> Allergies { get; set; }
    }
}
