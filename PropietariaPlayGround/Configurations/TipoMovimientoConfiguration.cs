using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropietariaPlayGround.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropietariaPlayGround.Configurations
{
    public class TipoMovimientoConfiguration : IEntityTypeConfiguration<TipoMovimiento>
    {
        public void Configure(EntityTypeBuilder<TipoMovimiento> builder)
        {
            builder.ToTable("TiposMovimientos");

            builder.HasKey(t => t.Id);

            builder.HasMany(t => t.Asientos)
                .WithOne(a => a.TipoMovimiento)
                .HasForeignKey(a => a.IdTipoMovimiento);

            builder
                .HasData(
                new TipoMovimiento() { Id = 1, Nombre = "DB" },
                new TipoMovimiento() { Id = 2, Nombre = "CR" });
        }
    }
}
