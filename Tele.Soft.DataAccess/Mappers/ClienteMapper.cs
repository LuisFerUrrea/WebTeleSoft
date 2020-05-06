using System;
using System.Collections.Generic;
using System.Text;
using Tele.Soft.Business.Models;
using Tele.Soft.DataAccess.Contracts.Entities;

namespace Tele.Soft.DataAccess.Mappers
{
    public static class ClienteMapper
    {
        public static ClienteEntity Map(Cliente dto)
        {
            return new ClienteEntity()
            {
                Id = dto.Id,
                Nombre = dto.Nombre,
                Correo = dto.Correo
            };
        }

        public static Cliente Map(ClienteEntity entity)
        {
            return new Cliente()
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Correo = entity.Correo
            };
        }
    }
}
