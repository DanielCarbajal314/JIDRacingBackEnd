using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Services.DataTransformation;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using Services.Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Implementation.EF.Client
{
    public class GetAllClientHandler : IGetAllClientHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public GetAllClientHandler(JIDRacingDbContext dbContext) 
        {
            this._dbContext = dbContext;
        }


        public async Task<IEnumerable<RegisteredClient>> Handle(GetAllClientsRequest request, CancellationToken cancellationToken)
        {
            var clients = await this._dbContext.Clients.ToListAsync();
            return clients.Select(x => x.ToDTO());
        }
    }
}
