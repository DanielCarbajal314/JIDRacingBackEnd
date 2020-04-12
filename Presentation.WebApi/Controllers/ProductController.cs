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
    public class ProductController : ControllerBase
    {
        IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<RegisteredProduct>> GetAll([FromQuery]GetAllProductsRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost("register")]
        public async Task<RegisteredProduct> AddNewClient([FromBody] NewProductRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPut("update")]
        public async Task<RegisteredProduct> UpdateClient([FromBody]UpdateProductRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}