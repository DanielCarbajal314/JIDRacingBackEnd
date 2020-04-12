using MediatR;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;

namespace Services.Interfaces.Handlers.Client
{
    public interface INewClientHandler : IRequestHandler<NewClientRequest, RegisteredClient>
    {
    }
}
