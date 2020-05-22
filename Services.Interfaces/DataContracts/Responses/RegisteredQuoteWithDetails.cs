using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Responses
{
    public class RegisteredQuoteWithDetails
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
        public IEnumerable<RegisteredQuoteDetail> Details { get; set; }
    }

    public class RegisteredQuoteDetail 
    {
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public double FinalPrice { get; set; }
        public double SubTotal { get; set; }
    }

}
