using Infrastructure.EFDbContext;
using Microsoft.EntityFrameworkCore;
using Services.DataTransformation;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;
using Services.Interfaces.Handlers.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Implementation.EF.Product
{
    public class UpdateProductHandler : IUpdateProductHandler
    {
        private readonly JIDRacingDbContext _dbContext;

        public UpdateProductHandler(JIDRacingDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<RegisteredProduct> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            var product = request.ToEntity();
            this._dbContext.Products.Attach(product).State = EntityState.Modified;
            await this._dbContext.SaveChangesAsync();
            return product.ToDTO();
        }
    }
}
