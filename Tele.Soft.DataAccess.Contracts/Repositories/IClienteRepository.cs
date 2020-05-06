using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.Contracts.Repositories
{   
    public interface IClienteRepository : IRepository<ClienteEntity>
    {
        Task<ClienteEntity> Update(ClienteEntity entity);
    }
}
