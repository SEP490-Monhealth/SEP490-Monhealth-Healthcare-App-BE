using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications
{
    public class GetAllUserNotificationsQuery : IRequest<PageResult<GetAllUserNotificationsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public GetAllUserNotificationsQuery(int page, int limit, string? search)
        {
            Page = page;
            Limit = limit;
            Search = search;
        }
    }
}
