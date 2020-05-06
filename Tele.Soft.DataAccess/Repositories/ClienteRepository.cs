using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tele.Soft.DataAccess.Contracts;
using Tele.Soft.DataAccess.Contracts.Entities;
using Tele.Soft.DataAccess.Contracts.Repositories;

namespace Tele.Soft.DataAccess.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ITeleSoftDBContext _teleSoftDBContext;

        public ClienteRepository(ITeleSoftDBContext teleSoftDBContext)
        {
            _teleSoftDBContext = teleSoftDBContext;
        }

        public async Task<ClienteEntity> Update(int idEntity, ClienteEntity updateEnt)
        {

            var entity = await Get(idEntity);

            entity.Nombre = updateEnt.Nombre;

            _teleSoftDBContext.Clientes.Update(entity);

            await _teleSoftDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ClienteEntity> Update(ClienteEntity entity)
        {

            var updateEntity = _teleSoftDBContext.Clientes.Update(entity);

            await _teleSoftDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<ClienteEntity> Add(ClienteEntity entity)
        {
            //throw new Exception("error prueba");

            await _teleSoftDBContext.Clientes.AddAsync(entity);

            await _teleSoftDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ClienteEntity> Get(int idEntity)
        {

            var result = await _teleSoftDBContext.Clientes.FindAsync(idEntity);

            return result;

        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ClienteEntity>> GetAll()
        {
            return _teleSoftDBContext.Clientes.Select(x => x);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _teleSoftDBContext.Clientes.FindAsync(id);

            _teleSoftDBContext.Clientes.Remove(entity);

            await _teleSoftDBContext.SaveChangesAsync();

        }
    }
}
