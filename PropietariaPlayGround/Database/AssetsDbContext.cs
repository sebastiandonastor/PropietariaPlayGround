using Microsoft.EntityFrameworkCore;
using PropietariaPlayGround.Configurations;
using PropietariaPlayGround.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropietariaPlayGround.Database
{
    public class AssetsDbContext : DbContext
    {
        public AssetsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AsientoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoMovimientoConfiguration());

        }

        public DbSet<Asiento> Asientos { get; set; }

        public DbSet<TipoMovimiento> TiposMovimientos { get; set; }

    }
}
