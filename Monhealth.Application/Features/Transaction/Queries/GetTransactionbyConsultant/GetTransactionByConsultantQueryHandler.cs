using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application
{
    public class GetTransactionByConsultantQuery : IRequest<PageResult<GetTransactionByConsultantDTO>>
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
    public class GetTransactionByConsultantQueryHandler(ITransactionRepository transactionRepository, ILogger<GetTransactionByConsultantQueryHandler> _logger)
      : IRequestHandler<GetTransactionByConsultantQuery, PageResult<GetTransactionByConsultantDTO>>
    {
        public async Task<PageResult<GetTransactionByConsultantDTO>> Handle(GetTransactionByConsultantQuery request, CancellationToken cancellationToken)
        {
            // Log the parameters to ensure they're being passed correctly
            _logger.LogInformation($"Retrieving transactions for Consultant: {request.Consultant}, Page: {request.Page}, Limit: {request.Limit}, Month: {request.Month}");

            // Get the transactions from the repository
            var queries = await transactionRepository.GetAllTransactionByConsultantId(request.Page, request.Limit, request.Consultant, request.Month);

            // Log the count of transactions returned by the repository
            _logger.LogInformation($"Total transactions retrieved: {queries.Items}");

            List<GetTransactionByConsultantDTO> getTransactionByConsultantDTOs = new List<GetTransactionByConsultantDTO>();

            foreach (var transaction in queries.Items)
            {
                // Log dữ liệu trước khi kiểm tra null
                _logger.LogInformation($"Processing Transaction ID: {transaction.TransactionId} - Booking: {transaction.Booking}, Consultant: {transaction.Booking?.Consultant}, AppUser: {transaction.Booking?.Consultant?.AppUser}");

                // Kiểm tra nếu transaction.Booking là null
                if (transaction.Booking != null && transaction.Booking.Consultant != null && transaction.Booking.Consultant.AppUser != null)
                {
                    var transactionDTO = new GetTransactionByConsultantDTO
                    {
                        Amount = transaction.Amount,
                        BookingId = transaction.Booking.BookingId,
                        ConsultantId = transaction.Booking.Consultant.ConsultantId,
                        Description = transaction.Description,
                        TransactionId = transaction.TransactionId,
                        Status = transaction.Status,
                        WalletId = transaction.Wallet.WalletId,
                        TransactionType = transaction.TransactionType,
                        Consultant = new ConsultantForTransaction
                        {
                            AvatarUrl = transaction.Booking.Consultant.AppUser.Avatar,
                            Email = transaction.Booking.Consultant.AppUser.Email,
                            FullName = transaction.Booking.Consultant.AppUser.FullName,
                            PhoneNumber = transaction.Booking.Consultant.AppUser.PhoneNumber
                        }
                    };

                    getTransactionByConsultantDTOs.Add(transactionDTO);
                }
                else
                {
                    // Log cảnh báo nếu dữ liệu liên kết bị thiếu
                    _logger.LogWarning($"Transaction with ID {transaction.TransactionId} has missing related data (Booking, Consultant, or AppUser is null).");
                }
            }


            // Log the total number of valid transactions added to the DTO list
            _logger.LogInformation($"Total valid transactions added to DTO list: {getTransactionByConsultantDTOs.Count}");

            // Return the paginated result
            return new PageResult<GetTransactionByConsultantDTO>()
            {
                Items = getTransactionByConsultantDTOs,
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount
            };
        }
    }


}