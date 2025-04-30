namespace Monhealth.Infrastructure.JobServices
{
    public interface IHangFireJobServices
    {
        Task HandleAutoUpdateReviewStatusAsync(Guid bookingId);
    }
}
