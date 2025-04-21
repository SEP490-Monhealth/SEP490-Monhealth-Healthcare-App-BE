namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityDTO
    {
        public Guid UserId { get; set; }
        public Guid WorkoutId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}