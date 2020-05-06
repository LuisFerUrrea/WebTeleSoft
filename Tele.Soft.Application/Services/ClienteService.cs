using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tele.Soft.Application.Contracts.Services;
using Tele.Soft.Business.Models;
using Tele.Soft.DataAccess.Contracts.Repositories;
using Tele.Soft.DataAccess.Mappers;

namespace Tele.Soft.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<string> GetClienteNombre(int id)
        {
            var entidad = await _clienteRepository.Get(id);
            return entidad.Nombre;
        }

        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            var addedEntity = await _clienteRepository.Add(ClienteMapper.Map(cliente));
            return ClienteMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            var clientes = await _clienteRepository.GetAll();
            return clientes.Select(ClienteMapper.Map);
        }

        public async Task<Cliente> GetCliente(int id)
        {
            var entidad = await _clienteRepository.Get(id);

            return ClienteMapper.Map(entidad);
        }

        public async Task DeleteCliente(int id)
        {
            await _clienteRepository.DeleteAsync(id);
        }

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            var updated = await _clienteRepository.Update(ClienteMapper.Map(cliente));
            return ClienteMapper.Map(updated);
        }
    }
}
