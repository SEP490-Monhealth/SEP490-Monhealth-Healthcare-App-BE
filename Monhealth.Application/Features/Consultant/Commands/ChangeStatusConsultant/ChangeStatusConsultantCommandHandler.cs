using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Consultant.Commands.ChangeStatusConsultant
{
    public class ChangeStatusConsultantCommandHandler : IRequestHandler<ChangeStatusConsultantCommand, bool>
    {
        private readonly IConsultantRepository _consultantRepository;
        private readonly IWalletRepository _walletRepository;
        public ChangeStatusConsultantCommandHandler(IConsultantRepository consultantRepository, IWalletRepository walletRepository)
        {
            _consultantRepository = consultantRepository;
            _walletRepository = walletRepository;
        }
        public async Task<bool> Handle(ChangeStatusConsultantCommand request, CancellationToken cancellationToken)
        {
            var consultant = await _consultantRepository.GetByIdAsync(request.ConsultantId);
            if (consultant == null)
            {
                throw new Exception("Không tìm thấy tư vấn viên");
            }
            consultant.Status = !consultant.Status;
            _consultantRepository.Update(consultant);
            

            var wallet = await _walletRepository.GetWalletByConsultantId(request.ConsultantId);
            if (wallet == null)
            {
                throw new Exception("Không tìm thấy ví");
            }
            wallet.Status = !wallet.Status;
            _walletRepository.Update(wallet);
            await _consultantRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}
