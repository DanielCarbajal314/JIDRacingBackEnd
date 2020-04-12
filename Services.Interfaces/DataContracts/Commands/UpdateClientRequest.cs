using MediatR;
using Services.Interfaces.DataContracts.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.DataContracts.Commands
{
    public class UpdateClientRequest : IRequest<RegisteredClient>
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }
        public string LastNames { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
