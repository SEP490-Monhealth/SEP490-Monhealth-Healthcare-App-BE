﻿using MediatR;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Queries.GetAllTransactions
{
    public class GetAllTransactionsQuery : IRequest<PageResult<GetAllTransactionsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public TransactionType? Type { get; set; }
        public string? Search { get; set; }
        public StatusTransaction? Status { get; set; }

        public GetAllTransactionsQuery(int page, int limit, TransactionType? type, string search, StatusTransaction? status)
        {
            Page = page;
            Limit = limit;
            Type = type;
            Search = search;
            Status = status;
        }
    }
}
