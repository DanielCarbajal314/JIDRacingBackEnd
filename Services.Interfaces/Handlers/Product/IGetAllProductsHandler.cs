using MediatR;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Handlers.Product
{
    public interface IGetAllProductsHandler : IRequestHandler<GetAllProductsRequest, IEnumerable<RegisteredProduct>>
    {
    }
}
