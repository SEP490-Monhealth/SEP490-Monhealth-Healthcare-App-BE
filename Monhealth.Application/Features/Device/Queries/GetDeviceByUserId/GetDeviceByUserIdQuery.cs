using MediatR;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceByUserId
{
    public class GetDeviceByUserIdQuery : IRequest<List<GetDeviceByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}
