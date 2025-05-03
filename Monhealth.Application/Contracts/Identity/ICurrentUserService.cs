namespace Monhealth.Application.Contracts.Identity
{
    public interface ICurrentUserService
    {
        Guid? GetCurrentUserId();
        bool IsAuthenticated { get; }

    }
}
