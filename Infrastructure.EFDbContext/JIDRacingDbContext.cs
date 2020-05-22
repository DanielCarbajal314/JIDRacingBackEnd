using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.EFDbContext
{
    public class JIDRacingDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<QuoteDetail> QuoteDetails { get; set; }

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
