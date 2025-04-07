using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.UpdateUserDevice
{
    public class UpdateDeviceCommand : IRequest<bool>
    {
        public Guid UserDeviceId { get; set; }
        public UpdateDeviceDTO UpdateDeviceDTO { get; set; }
        public UpdateDeviceCommand(Guid userDeviceId, UpdateDeviceDTO updateDeviceDTO)
        {
            UserDeviceId = userDeviceId;
            UpdateDeviceDTO = updateDeviceDTO;
        }
    }
}
