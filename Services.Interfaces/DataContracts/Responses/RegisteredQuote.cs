using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Responses
{
    public class RegisteredQuote
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string Description { get; set; }
    }
}
