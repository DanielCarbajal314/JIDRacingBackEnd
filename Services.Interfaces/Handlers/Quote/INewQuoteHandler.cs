using MediatR;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Handlers.Quote
{
    public interface INewQuoteHandler : IRequestHandler<NewQuoteRequest, RegisteredQuote>
    {
    }
}
