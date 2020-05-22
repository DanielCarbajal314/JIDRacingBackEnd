using Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product: TEntity
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string TechnicalDescription { get; set; }
        public string AditionalDrescription { get; set; }
        public double Price { get; set; }
    }
}
