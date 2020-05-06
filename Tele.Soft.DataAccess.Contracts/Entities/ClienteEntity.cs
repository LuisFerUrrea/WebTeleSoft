using System;
using System.Collections.Generic;
using System.Text;

namespace Tele.Soft.DataAccess.Contracts.Entities
{
    public class ClienteEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public virtual IEnumerable<ClienteXServicioEntity> ClienteXServicios { get; set; }
        public virtual ICollection<ClienteSevicioXPaisEntity> ClienteSevicioXPais { get; set; }
    }
}
