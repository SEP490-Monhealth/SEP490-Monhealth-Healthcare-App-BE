using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice
{
    public class CreateDeviceCommand : IRequest<Unit>
    {
        public CreateDeviceDTO CreateDeviceDTO { get; set; }
        public CreateDeviceCommand(CreateDeviceDTO createDeviceDTO)
        {
            CreateDeviceDTO = createDeviceDTO;
        }
    }
}
