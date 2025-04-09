using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice
{
    public class UpdateDeviceCommand : IRequest<bool>
    {
        public Guid DeviceId { get; set; }
        public UpdateDeviceDTO UpdateDeviceDTO { get; set; }
        public UpdateDeviceCommand(Guid deviceId, UpdateDeviceDTO updateDeviceDTO)
        {
            DeviceId = deviceId;
            UpdateDeviceDTO = updateDeviceDTO;
        }
    }
}
