namespace Monhealth.Application.Features.UserSubscription.Commands.Create
{
    // public class CreateUserSubscriptionDTO
    // {
    //     public Guid UserId { get; set; }
    //     public Guid SubscriptionId { get; set; }
    //     public int Duration { get; set; }
    // }
    public record CreateUserSubscriptionDTO(Guid UserId, Guid SubscriptionId, int Duration);
}