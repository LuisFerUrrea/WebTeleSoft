using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.DataAccess.Contracts;
using Tele.Soft.DataAccess.Contracts.Entities;
using Tele.Soft.DataAccess.EntityConfig;

namespace Tele.Soft.DataAccess
{
    public class TeleSoftDBContext : IdentityDbContext<ApplicationUser>, ITeleSoftDBContext
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
      
        public DbSet<ServicioEntity> Servicios { get; set; }
        public DbSet<PaisEntity> Pais { get; set; }
        public DbSet<ClienteXServicioEntity> ClienteXServicios { get; set; }
        public DbSet<ClienteSevicioXPaisEntity> ClienteSevicioXPais { get; set; }

        public TeleSoftDBContext(DbContextOptions options) : base(options)
        {

        }

        public TeleSoftDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ClienteEntityConfig.SetEntityBuilder(modelBuilder.Entity<ClienteEntity>());
            ServicioEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServicioEntity>());
            PaisEntityConfig.SetEntityBuilder(modelBuilder.Entity<PaisEntity>());
            ClienteXServicioEntityConfig.SetEntityBuilder(modelBuilder.Entity<ClienteXServicioEntity>());
            ClienteSevicioXPaisEntityConfig.SetEntityBuilder(modelBuilder.Entity<ClienteSevicioXPaisEntity>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
