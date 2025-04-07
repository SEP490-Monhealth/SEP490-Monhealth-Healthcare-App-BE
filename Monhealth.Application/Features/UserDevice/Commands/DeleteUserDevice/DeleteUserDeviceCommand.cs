using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.DeleteUserDevice
{
    public class DeleteUserDeviceCommand : IRequest<bool>
    {
        public Guid UserDeviceId { get; set; }
    }
}
