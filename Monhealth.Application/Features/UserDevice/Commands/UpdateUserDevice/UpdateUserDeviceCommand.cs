using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice
{
    public class UpdateUserDeviceCommand : IRequest<bool>
    {
        public Guid UserDeviceId { get; set; }
        public UpdateUserDeviceDTO UpdateUserDeviceDTO { get; set; }
        public UpdateUserDeviceCommand(Guid userDeviceId, UpdateUserDeviceDTO updateUserDeviceDTO)
        {
            UserDeviceId = userDeviceId;
            UpdateUserDeviceDTO = updateUserDeviceDTO;
        }
    }
}
