using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.EntityConfig
{
    public class ClienteXServicioEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ClienteXServicioEntity> entityBuilder)
        {
            entityBuilder.ToTable("ClienteXServicios");

            entityBuilder.HasOne(x => x.Cliente).WithMany(x => x.ClienteXServicios).HasForeignKey(x => x.ClienteId);
            entityBuilder.HasOne(x => x.Servicio).WithMany(x => x.ClienteXServicios).HasForeignKey(x => x.ServicioId);

            entityBuilder.HasKey(x => new { x.ClienteId, x.ServicioId });
            entityBuilder.Property(x => x.ClienteId).IsRequired();
            entityBuilder.Property(x => x.ServicioId).IsRequired();

        }
    }
}
