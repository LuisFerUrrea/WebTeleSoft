using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.EntityConfig
{
    public class PaisEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<PaisEntity> entityBuilder)
        {
            entityBuilder.ToTable("Pais");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();
        }
    }
}
