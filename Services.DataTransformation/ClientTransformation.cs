using Domain.Entities;
using Services.Interfaces.DataContracts.Commands;
using Services.Interfaces.DataContracts.Responses;
using System;

namespace Services.DataTransformation
{
    public static class ClientTransformation
    {
        public static Client ToEntity(this NewClientRequest request) 
        {
            return new Client
            {
                Address = request.Address,
                DNI = request.DNI,
                Email = request.Email,
                LastNames = request.LastNames,
                Names = request.Names,
                Phone = request.Phone
            };
        }

        public static Client ToEntity(this UpdateClientRequest request)
        {
            return new Client
            {
                Id = request.Id,
                Address = request.Address,
                DNI = request.DNI,
                Email = request.Email,
                LastNames = request.LastNames,
                Names = request.Names,
                Phone = request.Phone
            };
        }

        public static RegisteredClient ToDTO(this Client entity)
        {
            return new RegisteredClient
            {
                Id = entity.Id,
                Address = entity.Address,
                DNI = entity.DNI,
                Email = entity.Email,
                LastNames = entity.LastNames,
                Names = entity.Names,
                Phone = entity.Phone
            };
        }
    }
}
