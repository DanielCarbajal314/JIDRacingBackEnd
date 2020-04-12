using MediatR;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using System.Collections.Generic;

namespace Services.Interfaces.Handlers
{
    public interface IGetAllClientHandler : IRequestHandler<GetAllClientsRequest, IEnumerable<RegisteredClient>>
    {
    }
}
