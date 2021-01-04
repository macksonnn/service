using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactive.Native.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reactive.Native.Infrastructure.Maping
{
    public class CartaoMap : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            //builder. ToTable("Manager");

            builder.HasKey(prop => prop.IdCartao);

            builder.Property(prop => prop.NumeroCartao);
            builder.Property(prop => prop.DataValidade);
            builder.Property(prop => prop.CVV);
            builder.Property(prop => prop.Bandeira);
            builder.Property(prop => prop.Nome);

        }
    }
}
