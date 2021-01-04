using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactive.Native.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reactive.Native.Infrastructure.Maping
{
    public class SaldoMap : IEntityTypeConfiguration<Saldo>
    {
        public void Configure(EntityTypeBuilder<Saldo> builder)
        {
            builder.HasKey(prop => prop.IdSaldo);
            builder.Property(prop => prop.SaldoDotz);
            builder.Property(prop => prop.SaldoReais);
            builder.Property(prop => prop.DataSaldo);
            builder.Ignore(prop => prop.SaldoDate);



        }
    }
}
