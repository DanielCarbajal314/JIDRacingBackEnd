using Domain.Entities.Shared;
using System;

namespace Domain.Entities
{
    public class Client : TEntity
    {
        public string Names { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }
        public string LastNames { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
