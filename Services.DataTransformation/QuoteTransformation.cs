using Domain.Entities;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.DataTransformation
{
    public static class QuoteTransformation
    {
        public static RegisteredQuoteWithDetails ToDTOWithDetails(this Quote entity) 
        {
            return new RegisteredQuoteWithDetails
            {
                Id = entity.Id,
                ClientName = $"{entity.Client.Names} {entity.Client.LastNames}",
                Date = entity.Date,
                Description = entity.Description,
                Total = entity.Total,
                Details = entity.Details.Select(x=>new RegisteredQuoteDetail 
                {
                    Quantity = x.Quantity,
                    FinalPrice = x.FinalPrice,
                    ProductName = x.Product.Name,
                    SubTotal = x.Quantity * x.FinalPrice
                })
            };
        }

        public static Quote ToDTOWithDetails(this NewQuoteRequest entity)
        {
            return new Quote
            {
                ClientId = entity.ClientId,
                Description = entity.Description,
                Total = entity.Details.Select(x=>x.FinalPrice*x.Quantity).Sum(),
                Details = entity.Details.Select(x=>new QuoteDetail
                    { 
                        Cost = x.Cost,
                        ProductId = x.ProductId,
                        Quantity = x.Quantity,
                        FinalPrice = x.FinalPrice,
                        SubTotal = x.FinalPrice * x.Quantity
                    }).ToHashSet()
            };
        }
    }
}
