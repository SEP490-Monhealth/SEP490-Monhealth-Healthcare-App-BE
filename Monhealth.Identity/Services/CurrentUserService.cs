using Microsoft.AspNetCore.Http;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Models.Identity;
using System.Security.Claims;

namespace Monhealth.Identity.Services
{
    public class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
    {
        public bool IsAuthenticated => httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated ?? false;

        public Guid? GetCurrentUserId()
        {
            var userId = httpContextAccessor.HttpContext?
                .User?.FindFirstValue(UserClaims.UserId);
            return !string.IsNullOrEmpty(userId) ? Guid.Parse(userId) : null;
        }

    }
}
