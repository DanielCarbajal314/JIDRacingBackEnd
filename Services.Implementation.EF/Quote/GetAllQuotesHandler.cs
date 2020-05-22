using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using Services.Interfaces.Handlers.Quote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Implementation.EF.Quote
{
    public class GetAllQuotesHandler : IGetAllQuotesHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public GetAllQuotesHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<RegisteredQuote>> Handle(GetAllQuotesRequest request, CancellationToken cancellationToken)
        {
            return await this._dbContext.Quotes.Select(x => new RegisteredQuote
            {
                Id = x.Id,
                ClientName = $"{x.Client.Names} {x.Client.LastNames}",
                Date = x.Date,
                Description = x.Description,
                Total = x.Total
            }).ToListAsync();
        }
    }
}
