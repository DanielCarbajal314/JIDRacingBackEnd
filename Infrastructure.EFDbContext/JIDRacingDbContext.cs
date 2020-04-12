using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.EFDbContext
{
    public class JIDRacingDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        public JIDRacingDbContext(DbContextOptions<JIDRacingDbContext> options): base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
