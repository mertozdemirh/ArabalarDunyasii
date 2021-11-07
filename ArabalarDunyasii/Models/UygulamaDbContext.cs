using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabalarDunyasii.Models
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Araba> Arabalar { get; set; }

        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>().HasData(
                new Araba() { Id = 1, Model = "Volkswagen Passat 1.6 TDI BlueMotion ComfortLine", Yil = 2018 },
                new Araba() { Id = 2, Model = "Seat Ibiza 1.6 Stella", Yil = 2001 },
                new Araba() { Id = 3, Model = "Renault Fluence 1.5 dCi Authentique", Yil = 2011 },
                new Araba() { Id = 4, Model = "Seat Leon 1.6 TDI CR Style", Yil = 2014 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
