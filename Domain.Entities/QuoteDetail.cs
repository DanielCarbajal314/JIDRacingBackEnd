using Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class QuoteDetail : TEntity
    {
        public double Cost { get; set; }
        public double FinalPrice { get; set; }
        public Quote Quote { get; set; }
        public int QuoteId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double SubTotal { get; set; }
    }
}
