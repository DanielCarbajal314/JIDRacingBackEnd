using MediatR;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Commands
{
    public class NewQuoteRequest : IRequest<RegisteredQuote>
    {
        public int ClientId { get; set; }
        public string Description { get; set; }
        public IEnumerable<NewQuoteDetailsRequest> Details { get; set; }
    }

    public class NewQuoteDetailsRequest 
    {
        public double Cost { get; set; }
        public double FinalPrice { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
