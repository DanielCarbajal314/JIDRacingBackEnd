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
    public class ClientController : ControllerBase
    {
        IMediator _mediator;

        public ClientController(IMediator mediator) 
        {
            this._mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<RegisteredClient>> GetAll([FromQuery]GetAllClientsRequest request) 
        {
            return await _mediator.Send(request);
        }

        [HttpPost("register")]
        public async Task<RegisteredClient> AddNewClient([FromBody] NewClientRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPut("update")]
        public async Task<RegisteredClient> UpdateClient([FromBody]UpdateClientRequest request)
        {
            return await _mediator.Send(request);
        }


    }
}