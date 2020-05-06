using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tele.Soft.Business.Models;

namespace Tele.Soft.Application.Contracts.Services
{
    public interface IClienteService
    {
        Task<string> GetClienteNombre(int id);
        Task<Cliente> AddCliente(Cliente cliente);
        Task<IEnumerable<Cliente>> GetAllClientes();
        Task<Cliente> GetCliente(int id);
        Task DeleteCliente(int id);
        Task<Cliente> UpdateCliente(Cliente cliente);       

    }
}
