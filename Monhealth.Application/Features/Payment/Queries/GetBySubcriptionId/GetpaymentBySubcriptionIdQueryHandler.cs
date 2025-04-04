﻿using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetpaymentBySubcriptionIdQueryHandler(IPaymentRepository paymentRepository, IMapper mapper, IUserRepository userRepository) : IRequestHandler<GetpaymentBySubcriptionIdQuery, List<GetPaymentBySubscriptionIdDTO>>
    {
        public async Task<List<GetPaymentBySubscriptionIdDTO>> Handle(GetpaymentBySubcriptionIdQuery request, CancellationToken cancellationToken)
        {
            var queries = await paymentRepository.GetPaymentBySubscriptionId(request.SubscriptionId);



            var paymentList = new List<GetPaymentBySubscriptionIdDTO>();

            foreach (var payment in queries)
            {
                if (payment.UserSubscription == null)
                {
                    throw new Exception($"Thanh toán {payment.PaymentId} không tìm thấy.");
                }
                var member = await userRepository.GetUserByIdAsync(payment.UserSubscription.UserId);
                if (member == null)
                {
                    throw new Exception($"User with ID {payment.UserSubscription.UserId} not found.");
                }
                var memberDTO = new Member
                {
                    AvatarUrl = member.Avatar,
                    Email = member.Email,
                    FullName = member.FullName,
                    PhoneNumber = member.PhoneNumber,
                };

                var paymentDTO = new GetPaymentBySubscriptionIdDTO
                {
                    PaymentId = payment.PaymentId,
                    SubscriptionId = payment.UserSubscription.SubscriptionId,
                    Member = memberDTO,
                    SubscriptionName = payment.UserSubscription.Subscription.SubscriptionName,
                    Amount = payment.Amount,
                    Status = payment.Status,
                    CreatedAt = payment.CreatedAt,
                    UpdatedAt = payment.UpdatedAt,
                    CreatedBy = payment.CreatedBy,
                    UpdatedBy = payment.UpdatedBy
                };

                paymentList.Add(paymentDTO);
            }

            return paymentList;
        }
    }
}
