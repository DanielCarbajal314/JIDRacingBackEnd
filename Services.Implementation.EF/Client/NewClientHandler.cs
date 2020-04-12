using Infrastructure.EFDbContext;
using Services.DataTransformation;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;
using Services.Interfaces.Handlers.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Implementation.EF.Client
{
    public class NewClientHandler : INewClientHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public NewClientHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<RegisteredClient> Handle(NewClientRequest request, CancellationToken cancellationToken)
        {
            var client = request.ToEntity();
            this._dbContext.Clients.Add(client);
            await this._dbContext.SaveChangesAsync();
            return client.ToDTO();
        }
    }
}
