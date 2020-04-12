using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Services.DataTransformation;
using Services.Interfaces.DataContracts.Queries;
using Services.Interfaces.DataContracts.Responses;
using Services.Interfaces.Handlers.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Implementation.EF.Product
{
    public class GetAllProductsHandler : IGetAllProductsHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public GetAllProductsHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<RegisteredProduct>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {
            var products = await this._dbContext.Products.ToListAsync();
            return products.Select(x => x.ToDTO());
        }
    }
}
