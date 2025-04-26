using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Transaction.Queries.GetAllTransactions;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application
{
    public class GetTransactionByConsultantQuery : IRequest<PageResult<GetAllTransactionsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Month { get; set; }
        public Guid Consultant;
        public GetTransactionByConsultantQuery(int page, int limit, string? month, Guid consultant)
        {
            Page = page;
            Limit = limit;
            Month = month;
            Consultant = consultant;
        }
    }
    public class GetTransactionByConsultantQueryHandler(ITransactionRepository transactionRepository
    , ILogger<GetTransactionByConsultantQueryHandler> _logger, IMapper _mapper)
      : IRequestHandler<GetTransactionByConsultantQuery, PageResult<GetAllTransactionsDTO>>
    {
        public async Task<PageResult<GetAllTransactionsDTO>> Handle(GetTransactionByConsultantQuery request, CancellationToken cancellationToken)
        {
            // Log the parameters to ensure they're being passed correctly
            _logger.LogInformation($"Retrieving transactions for Consultant: {request.Consultant}, Page: {request.Page}, Limit: {request.Limit}, Month: {request.Month}");

            // Get the transactions from the repository
            var queries = await transactionRepository.GetAllTransactionByConsultantId(request.Page, request.Limit, request.Consultant, request.Month);

            // // Log the count of transactions returned by the repository
            // _logger.LogInformation($"Total transactions retrieved: {queries.Items}");

            // List<GetTransactionByConsultantDTO> getTransactionByConsultantDTOs = new List<GetTransactionByConsultantDTO>();

            // foreach (var transaction in queries.Items)
            // {
            //     // Log dữ liệu trước khi kiểm tra null
            //     _logger.LogInformation($"Processing Transaction ID: {transaction.TransactionId} - Booking: {transaction.Booking}, Consultant: {transaction.Booking?.Consultant}, AppUser: {transaction.Booking?.Consultant?.AppUser}");

            //     // Kiểm tra nếu transaction.Booking là null
            //         var transactionDTO = new GetTransactionByConsultantDTO
            //         {
            //             Amount = transaction.Amount,
            //             BookingId = transaction.Booking.BookingId,
            //             ConsultantId = transaction.Booking.Consultant.ConsultantId,
            //             Description = transaction.Description,
            //             TransactionId = transaction.TransactionId,
            //             Status = transaction.Status,
            //             WalletId = transaction.Wallet.WalletId,
            //             TransactionType = transaction.TransactionType,
            //             Consultant = new ConsultantForTransaction
            //             {
            //                 AvatarUrl = transaction.Booking.Consultant.AppUser.Avatar,
            //                 Email = transaction.Booking.Consultant.AppUser.Email,
            //                 FullName = transaction.Booking.Consultant.AppUser.FullName,
            //                 PhoneNumber = transaction.Booking.Consultant.AppUser.PhoneNumber
            //             }
            //         };

            //         getTransactionByConsultantDTOs.Add(transactionDTO);

            // }


            // // Log the total number of valid transactions added to the DTO list
            // _logger.LogInformation($"Total valid transactions added to DTO list: {getTransactionByConsultantDTOs.Count}");
            var listTransactionsDto = _mapper.Map<List<GetAllTransactionsDTO>>(queries.Items);

            // Return the paginated result
            return new PageResult<GetAllTransactionsDTO>()
            {
                Items = listTransactionsDto,
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = listTransactionsDto.Count
            };
        }
    }


}