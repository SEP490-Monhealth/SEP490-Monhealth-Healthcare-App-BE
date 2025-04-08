using MediatR;
using Microsoft.AspNetCore.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;
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
                throw new BadRequestException("Không tìm thấy chuyên viên");



            switch (consultant.IsVerified)
            {
                case VerificationStatus.Verified:
                    throw new BadRequestException("Tài khoản đã được xác thực trước đó");

                case VerificationStatus.Pending:
                    consultant.IsVerified = VerificationStatus.Verified;
                    consultant.Status = true;

                    var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
                    if (wallet == null)
                        throw new BadRequestException("Không tìm thấy ví của chuyên viên");

                    wallet.Status = true;
                    _walletRepository.Update(wallet);
                    break;

                default:
                    throw new BadRequestException("Trạng thái xác thực không hợp lệ");
            }

            _consultantRepository.Update(consultant);
            await _consultantRepository.SaveChangeAsync();
            return true;
        }
    }
}
