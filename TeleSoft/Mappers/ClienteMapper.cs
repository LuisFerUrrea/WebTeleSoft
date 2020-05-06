using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tele.Soft.Business.Models;
using TeleSoft.ViewModels;

namespace TeleSoft.Mappers
{
    public static class ClienteMapper
    {
        public static Cliente Map(ClienteModel model)
        {
            return new Cliente()
            {
                Id = model.Id,
                Nombre = model.Nombre,
                Correo = model.Correo,               
            };

        }
    }
}
