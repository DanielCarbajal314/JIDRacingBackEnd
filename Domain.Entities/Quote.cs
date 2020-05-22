using Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Quote : TEntity
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public HashSet<QuoteDetail> Details { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
    }
}
