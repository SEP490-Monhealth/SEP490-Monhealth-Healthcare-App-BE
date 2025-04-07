using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.DeleteUserDevice
{
    public class DeleteDeviceCommand : IRequest<bool>
    {
        public Guid UserDeviceId { get; set; }
    }
}
