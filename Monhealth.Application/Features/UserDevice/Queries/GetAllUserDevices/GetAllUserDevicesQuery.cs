using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices
{
    public class GetAllUserDevicesQuery : IRequest<PageResult<GetAllUserDevicesDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetAllUserDevicesQuery(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}
