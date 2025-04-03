using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetAllNotifications
{
    public class GetAllNotificationsQuery : IRequest<PageResult<GetAllNotificationsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string Search { get; set; }
        public GetAllNotificationsQuery(int page, int limit, string search)
        {
            Page = page;
            Limit = limit;
            Search = search;
        }
    }
}
