﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Responses
{
    public class RegisteredProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string TechnicalDescription { get; set; }
        public string AditionalDrescription { get; set; }
    }
}
