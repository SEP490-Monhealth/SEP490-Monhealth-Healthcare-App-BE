namespace Monhealth.Application.Features.Activity.Commands.CreateActivity
{
    public class CreateActivityDTO
    {
        public Guid? WorkoutId { get; set; }
        public Guid? UserId { get; set; }
    }
}