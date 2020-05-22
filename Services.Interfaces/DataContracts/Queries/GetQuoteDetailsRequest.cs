using MediatR;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Queries
{
    public class GetQuoteDetailsRequest : IRequest<RegisteredQuoteWithDetails> 
    {
        public int QuoteId { get; set; }
    }
}
