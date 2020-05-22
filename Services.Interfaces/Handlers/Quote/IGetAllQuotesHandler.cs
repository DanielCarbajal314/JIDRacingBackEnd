using MediatR;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Handlers.Quote
{
    public interface IGetAllQuotesHandler : IRequestHandler<GetAllQuotesRequest, IEnumerable<RegisteredQuote>>
    {
    }
}
