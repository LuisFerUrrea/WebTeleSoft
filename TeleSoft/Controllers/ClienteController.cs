using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tele.Soft.Application.Contracts.Services;
using TeleSoft.Mappers;
using TeleSoft.ViewModels;

namespace TeleSoft.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;      

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
          
        }

        /// <summary>
        /// Get cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Cliente</returns>
        [HttpGet("[action]")]
        [Produces("application/json", Type = typeof(ClienteModel))]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cliente = await _clienteService.GetCliente(id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
               return  BadRequest(ex.Message);
            }
            
        }

      
        [HttpGet("[action]")]
        [Produces("application/json", Type = typeof(List<ClienteModel>))]
        public async Task<IActionResult> GetAll()
        {          
            try
            {
                var clientes = await _clienteService.GetAllClientes();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Add a new Cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Cliente</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(ClienteModel))]
        [HttpPost("[action]")]
        public async Task<IActionResult> AddCliente([FromBody]ClienteModel clienteModel)
        {          
            try
            {
                var cliente = await _clienteService.AddCliente(ClienteMapper.Map(clienteModel));
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Borra un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Cliente</returns>
        [HttpDelete("[action]")]
        [Produces("application/json", Type = typeof(bool))]
        public async Task<IActionResult> DeleteCliente(int id)
        {           
            try
            {
                await _clienteService.DeleteCliente(id);
                return Ok("Registro eliminado correctamente");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un Cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Cliente</returns>
        [HttpPut("[action]")]
        [Produces("application/json", Type = typeof(ClienteModel))]
        public async Task<IActionResult> UpdateCliente([FromBody]ClienteModel clienteModel)
        {           
            try
            {
                var cliente = await _clienteService.UpdateCliente(ClienteMapper.Map(clienteModel));
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}