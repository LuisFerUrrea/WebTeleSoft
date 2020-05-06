using System;
using System.Collections.Generic;
using System.Text;

namespace Tele.Soft.DataAccess.Contracts.Entities
{
    public class ClienteXServicioEntity
    {     

        public int ClienteId { get; set; }

        public int ServicioId { get; set; }

        public virtual ClienteEntity Cliente { get; set; }
        public virtual ServicioEntity Servicio { get; set; }
    }
}
