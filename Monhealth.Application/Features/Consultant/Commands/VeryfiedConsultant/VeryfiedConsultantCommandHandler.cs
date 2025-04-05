using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Features.Consultant.Commands.VeryfiedConsultant
{
    public class VeryfiedConsultantCommandHandler : IRequestHandler<VeryfiedConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IUserRepository _userRepository;
        public VeryfiedConsultantCommandHandler(IConsultantRepository consultantRepository,
         IWalletRepository walletRepository, UserManager<AppUser> userManager,
         IUserRoleRepository userRoleRepository,
         IUserRepository userRepository)
        {
            _consultantRepository = consultantRepository;
            _walletRepository = walletRepository;
            _userManager = userManager;
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(VeryfiedConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                return false;
            }


            if (!consultant.IsVerified)
            {
                consultant.IsVerified = !consultant.IsVerified;
                consultant.Status = true;

                // var consultantRole = await _userRoleRepository.GetRoleConsultant("Consultant");
                // // xoa role
                // var userRole = await _userRoleRepository.GetUserRoleByUserIdAsync(request.ConsultantId);
                // if (userRole != null)
                // {
                //     // Nếu người dùng đã có role, xóa bản ghi cũ trước khi thêm role mới
                //     _userRoleRepository.Remove(userRole);
                //     await _userRepository.SaveChangesAsync();
                // }
                // // Tạo bản ghi mới cho UserRole với RoleId mới
                // var newUserRole = new IdentityUserRole<Guid>
                // {
                //     UserId = request.ConsultantId,
                //     RoleId = consultantRole.Id
                // };
                // _userRoleRepository.Add(newUserRole);
                // await _userRepository.SaveChangesAsync();

                var consultantRole = await _userRoleRepository.GetRoleConsultant("Consultant");
                // xoa role
                var userId = consultant?.UserId;
                if (userId.HasValue)
                {
                    var userRole = await _userRoleRepository.GetUserRoleByUserIdAsync(userId.Value);
                    if (userRole != null)
                    {
                        // Nếu người dùng đã có role, xóa bản ghi cũ trước khi thêm role mới
                        _userRoleRepository.Remove(userRole);
                        await _userRepository.SaveChangesAsync();
                    }
                    // Tạo bản ghi mới cho UserRole với RoleId mới
                    var newUserRole = new IdentityUserRole<Guid>
                    {
                        UserId = userId.Value,
                        RoleId = consultantRole.Id
                    };
                    _userRoleRepository.Add(newUserRole);
                }

                // Thay đổi trạng thái wallet
                var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
                if (wallet == null)
                {
                    return false;
                }
                wallet.Status = true;
                _walletRepository.Update(wallet);
            }
            _consultantRepository.Update(consultant);
            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
