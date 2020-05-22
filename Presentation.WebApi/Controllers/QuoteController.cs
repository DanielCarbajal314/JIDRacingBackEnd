using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;

namespace Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        IMediator _mediator;
        public QuoteController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RegisteredQuote>> GetAll([FromQuery]GetAllQuotesRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("{QuoteId}")]
        public async Task<RegisteredQuoteWithDetails> GetById([FromRoute]GetQuoteDetailsRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        public async Task<RegisteredQuote> RegisterNewQuote([FromBody]NewQuoteRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}