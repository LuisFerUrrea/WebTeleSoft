using System;
using System.Collections.Generic;
using System.Text;

namespace Tele.Soft.DataAccess.Contracts.Entities
{
    public class ClienteSevicioXPaisEntity
    {
        public int PaisId { get; set; }
        public int ClienteId { get; set; }

        public int ServicioId { get; set; }

        public virtual PaisEntity Pais { get; set; }

        public virtual ClienteEntity Cliente { get; set; }
        public virtual ServicioEntity Servicio { get; set; }
    }
}
