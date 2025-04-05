using MediatR;

namespace Monhealth.Application.Features.UserDevice.Commands.CreateUserDevice
{
    public class CreateUserDeviceCommand : IRequest<Unit>
    {
        public CreateUserDeviceDTO CreateUserDeviceDTO { get; set; }
        public CreateUserDeviceCommand(CreateUserDeviceDTO createUserDeviceDTO)
        {
            CreateUserDeviceDTO = createUserDeviceDTO;
        }
    }
}
