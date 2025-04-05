using MediatR;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById
{
    public class GetUserDeviceByIdQuery : IRequest<GetUserDeviceByIdDTO>
    {
        public Guid UserDeviceId { get; set; }
    }
}
