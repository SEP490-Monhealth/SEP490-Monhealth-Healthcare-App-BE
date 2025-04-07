using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.UserDevice.Queries.GetAllUserDevices
{
    public class GetAllDevicesQuery : IRequest<PageResult<GetAllDevicesDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetAllDevicesQuery(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}
