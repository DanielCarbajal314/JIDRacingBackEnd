using MediatR;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Commands
{
    public class NewProductRequest : IRequest<RegisteredProduct>
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string TechnicalDescription { get; set; }
        public string AditionalDrescription { get; set; }
    }
}
