using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.EntityConfig
{
    public class ServicioEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<ServicioEntity> entityBuilder)
        {
            entityBuilder.ToTable("Servicios");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

        }
    }
}
