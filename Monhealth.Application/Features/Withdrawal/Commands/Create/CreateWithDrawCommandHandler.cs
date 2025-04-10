﻿using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class CreateWithDrawCommandHandler(IWithdrawalRepository withdrawalRepository,
                                                IWalletRepository walletRepository,
                                                IConsultantBankRepository consultantBankRepository
        ) : IRequestHandler<CreateWithdrawalRequestDTO, bool>
    {
        public async Task<bool> Handle(CreateWithdrawalRequestDTO request, CancellationToken cancellationToken)
        {
            var wallet = await walletRepository.GetWalletByConsultantId(request.ConsultantId);
            if (wallet == null)
            {
                throw new BadRequestException("Không tìm thấy ví của chuyên viên tư vấn");
            }

            if (wallet.Balance < request.Amount)
            {
                throw new BadRequestException("Số dư không để để tạo yêu cầu rút tiền");
            };

            var consultantBank = await consultantBankRepository.GetConsultantBankById(request.ConsultantBankId);
            if (consultantBank == null) throw new BadRequestException("Không tìm thấy tài khoản ngân hàng của chuyên viên tư vấn");

            WithdrawalRequest model = new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.NewGuid(),
                Amount = request.Amount,
                ConsultantId = request.ConsultantId,
                ConsultantBankId = request.ConsultantBankId,
                Description = request.Description,
                Status = Domain.Enum.WithdrawalStatus.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            withdrawalRepository.Add(model);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
    }
}