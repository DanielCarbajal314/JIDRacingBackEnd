using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Services.DataTransformation;
using Services.Interfaces.DataContracts.Commands;
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
    public class NewQuoteHandler : INewQuoteHandler
    {
        private readonly JIDRacingDbContext _dbContext;
        public NewQuoteHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<RegisteredQuote> Handle(NewQuoteRequest request, CancellationToken cancellationToken)
        {
            var quote = request.ToDTOWithDetails();
            this._dbContext.Quotes.Add(quote);
            await this._dbContext.SaveChangesAsync();
            return await this._dbContext.Quotes.Select(x => new RegisteredQuote
            {
                Id = x.Id,
                ClientName = $"{x.Client.Names} {x.Client.LastNames}",
                Date = x.Date,
                Description = x.Description,
                Total = x.Total
            }).FirstOrDefaultAsync(x=>x.Id.Equals(quote.Id));
        }
    }
}
