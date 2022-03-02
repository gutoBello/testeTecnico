using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT.Infra.Domain.Entities;

namespace TesteTecnico.Infra.Data.EntitiesConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(c => c.Customer).WithMany(e => e.Orders).HasForeignKey(e => e.CustomerId);
            //Caso estivesse utilizando o EF Core 5, utilizaria o "HasPrecision" para a propriedade Price.
        }
    }
}
