using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Services.DataTransformation;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using Services.Interfaces.Handlers.Quote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Implementation.EF.Quote
{
    public class GetQuoteWithDetailsHandler : IGetQuoteWithDetailsHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public GetQuoteWithDetailsHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<RegisteredQuoteWithDetails> Handle(GetQuoteDetailsRequest request, CancellationToken cancellationToken)
        {
            var quote = await this._dbContext.Quotes
                .Include(x => x.Client)
                .Include(x => x.Details)
                    .ThenInclude(x=>x.Product)
                .FirstOrDefaultAsync(x => x.Id.Equals(request.QuoteId));
            return quote.ToDTOWithDetails();
        }
    }
}
