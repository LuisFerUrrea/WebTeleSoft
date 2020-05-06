using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.EntityConfig
{
    public class ClienteSevicioXPaisEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ClienteSevicioXPaisEntity> entityBuilder)
        {
            entityBuilder.ToTable("ClienteSevicioXPais");

            entityBuilder.HasOne(x => x.Pais).WithMany(x => x.ClienteSevicioXPais).HasForeignKey(x => x.PaisId);
            entityBuilder.HasOne(x => x.Cliente).WithMany(x => x.ClienteSevicioXPais).HasForeignKey(x => x.ClienteId);
            entityBuilder.HasOne(x => x.Servicio).WithMany(x => x.ClienteSevicioXPais).HasForeignKey(x => x.ServicioId);

            entityBuilder.HasKey(x => new {x.PaisId, x.ClienteId, x.ServicioId });
            entityBuilder.Property(x => x.PaisId).IsRequired();
            entityBuilder.Property(x => x.ClienteId).IsRequired();
            entityBuilder.Property(x => x.ServicioId).IsRequired();

        }
    }
}
