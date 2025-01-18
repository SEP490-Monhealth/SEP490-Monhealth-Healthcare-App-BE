namespace Monhealth.Application.Features.UserFood.Commands
{
    public class CreateUserFoodDto
    {
        public List<string> Categories { get; set; }
        public List<string> Allergies { get; set; }
    }
}
