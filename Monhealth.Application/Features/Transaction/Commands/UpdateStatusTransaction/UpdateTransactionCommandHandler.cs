﻿using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionCommandHandler : IRequestHandler<UpdateTransactionStatusQuery, bool>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IConsultantRepository _consultantRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly ISystemNotificationService systemNotificationService;
        private readonly IMapper _mapper;

        public UpdateTransactionCommandHandler(
            ITransactionRepository transactionRepository,
            IMapper mapper,
            IConsultantRepository consultantRepository,
            IWalletRepository walletRepository,
            ISystemNotificationService systemNotificationService
            )
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
            _consultantRepository = consultantRepository;
            _walletRepository = walletRepository;
            this.systemNotificationService = systemNotificationService;
        }

        public async Task<bool> Handle(UpdateTransactionStatusQuery request, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetTransactionById(request.TransactionId)
                ?? throw new BadRequestException("Không tìm thấy giao dịch");

            var wallet = await _walletRepository.GetWalletByConsultantId((Guid)transaction.ConsultantId)
                ?? throw new BadRequestException("Không tìm thấy ví của tư vấn viên");

            if (wallet.Balance is null || wallet.Balance < 0)
                throw new BadRequestException("Không đủ số dư trong ví để thực hiện giao dịch");

            switch (transaction.TransactionType)
            {
                case TransactionType.Earning:
                case TransactionType.Bonus:
                    wallet.Balance += transaction.Amount;
                    //notify to consultant 
                    await systemNotificationService.NotifyConsultantHasNewIncomeAsync(transaction, cancellationToken);
                    break;

                case TransactionType.Fee:
                case TransactionType.Withdrawal:
                    if (wallet.Balance < transaction.Amount)
                        throw new BadRequestException("Không đủ số dư trong ví để thực hiện giao dịch");
                    wallet.Balance -= transaction.Amount;

                    //notify to consultant 
                    await systemNotificationService.NotifyWithdrawalApprovedAsync(transaction, cancellationToken);
                    break;

                default:
                    throw new BadRequestException("Loại giao dịch không hợp lệ");
            }

            transaction.Status = StatusTransaction.Completed;
            transaction.UpdatedAt = GetCurrentVietnamTime();

            _transactionRepository.Update(transaction);
            await _transactionRepository.SaveChangeAsync();

            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
