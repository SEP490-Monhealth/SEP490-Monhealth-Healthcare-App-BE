using MediatR;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId
{
    public class GetUserDeviceByUserIdQuery : IRequest<List<GetUserDeviceByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
