using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.Contracts
{
    public interface ITeleSoftDBContext
    {
        DbSet<ClienteEntity> Clientes { get; set; }
        DbSet<ServicioEntity> Servicios { get; set; }
        DbSet<PaisEntity> Pais { get; set; }
        DbSet<ClienteXServicioEntity> ClienteXServicios { get; set; }
        DbSet<ClienteSevicioXPaisEntity> ClienteSevicioXPais { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
    }
}
