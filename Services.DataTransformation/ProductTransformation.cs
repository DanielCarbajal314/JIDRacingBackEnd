using Domain.Entities;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DataTransformation
{
    public static class ProductTransformation
    {
        public static Product ToEntity(this NewProductRequest request)
        {
            return new Product
            {
                AditionalDrescription = request.AditionalDrescription,
                Brand = request.Brand,
                Model = request.Model,
                Name = request.Name,
                TechnicalDescription = request.TechnicalDescription
            };
        }

        public static Product ToEntity(this UpdateProductRequest request)
        {
            return new Product
            {
                Id = request.Id,
                AditionalDrescription = request.AditionalDrescription,
                Brand = request.Brand,
                Model = request.Model,
                Name = request.Name,
                TechnicalDescription = request.TechnicalDescription
            };
        }

        public static RegisteredProduct ToDTO(this Product entity)
        {
            return new RegisteredProduct
            {
                Id = entity.Id,
                AditionalDrescription = entity.AditionalDrescription,
                Brand = entity.Brand,
                Model = entity.Model,
                Name = entity.Name,
                TechnicalDescription = entity.TechnicalDescription
            };
        }
    }
}
