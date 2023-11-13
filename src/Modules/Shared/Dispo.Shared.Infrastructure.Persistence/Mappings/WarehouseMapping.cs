﻿using Dispo.Shared.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dispo.Shared.Infrastructure.Persistence.Mappings
{
    public class WarehouseMapping : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("Warehouses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .UseIdentityColumn()
                   .HasColumnType("BIGINT")
                   .ValueGeneratedOnAdd();

            builder.Property(x => x.Ativo)
                   .IsRequired()
                   .HasColumnName("Ativo")
                   .HasDefaultValue(true);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnName("Name")
                   .HasColumnType("VARCHAR(60)")
                   .HasMaxLength(60);

            builder.HasOne(a => a.Address)
                   .WithOne(b => b.Warehouse)
                   .HasForeignKey<Warehouse>(c => c.AddressId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}