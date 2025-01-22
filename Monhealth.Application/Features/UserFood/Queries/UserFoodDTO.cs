namespace Monhealth.Application.Features.UserFood.Queries
{
    public class UserFoodDTO
    {

        public Guid UserFoodId { get; set; }
        public Guid UserId { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Allergies { get; set; }

    }
}