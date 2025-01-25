namespace Monhealth.Application.Features.UserFood.Commands.Update
{
    public class UpdateUserFoodRequest 
    {
        public List<string> Categories { get; set; }
        public List<string> Allergies { get; set; }
    }
}