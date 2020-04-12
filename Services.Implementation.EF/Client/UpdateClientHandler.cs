using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
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
    public class UpdateClientHandler : IUpdateClientHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public UpdateClientHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<RegisteredClient> Handle(NewClientRequest request, CancellationToken cancellationToken)
        {
            var client = request.ToEntity();
            this._dbContext.Clients.Attach(client).State = EntityState.Modified;
            await this._dbContext.SaveChangesAsync();
            return client.ToDTO();
        }
    }
}
