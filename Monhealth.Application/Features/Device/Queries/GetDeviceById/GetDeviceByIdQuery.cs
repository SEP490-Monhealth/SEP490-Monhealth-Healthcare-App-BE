using MediatR;

namespace Monhealth.Application.Features.UserDevice.Queries.GetUserDeviceById
{
    public class GetDeviceByIdQuery : IRequest<GetDeviceByIdDTO>
    {
        public Guid UserDeviceId { get; set; }
    }
}
