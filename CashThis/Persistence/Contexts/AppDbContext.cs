using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashThis.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CashThis.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyConversion> Conversions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Currency>().ToTable("Currencies");
            builder.Entity<Currency>().HasKey(p => p.Id);
            builder.Entity<Currency>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Currency>().Property(p => p.CurrencyName).IsRequired().HasMaxLength(30);
            builder.Entity<Currency>().HasMany(p => p.CurrencyConversions).WithOne(p => p.Currency).HasForeignKey(p => p.OriginalCurrencyId);

            //Seed data for some currencies
            builder.Entity<Currency>().HasData
            (
                new Currency { Id = 100, CurrencyName = "Canadian Dollar" },
                new Currency { Id = 101, CurrencyName = "United States Dollar" }
            );

            builder.Entity<CurrencyConversion>().ToTable("CurrencyConversions");
            builder.Entity<CurrencyConversion>().HasKey(p => p.Id);
            builder.Entity<CurrencyConversion>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<CurrencyConversion>().Property(p => p.ConversionName).IsRequired().HasMaxLength(30);
            builder.Entity<CurrencyConversion>().Property(p => p.DestinationCurrencyValue).IsRequired();

        }
    }
}
