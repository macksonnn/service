using Microsoft.EntityFrameworkCore;
using Reactive.Native.Domain.Entities;
using Reactive.Native.Infrastructure.Maping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reactive.Native.Infrastructure.Context
{
    public class DotzContext : DbContext
    {

        public DotzContext(DbContextOptions<DotzContext> options) : base(options)
        {
        }
       public DbSet<Saldo> Saldo { get; set; }

        public DbSet<Cartao> Cartao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Saldo>(new SaldoMap().Configure);
            modelBuilder.Entity<Cartao>(new CartaoMap().Configure);
        }

        

    }
}
