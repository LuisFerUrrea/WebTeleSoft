using System;
using System.Collections.Generic;
using System.Text;

namespace Tele.Soft.DataAccess.Contracts.Entities
{
    public class PaisEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual IEnumerable<ClienteSevicioXPaisEntity> ClienteSevicioXPais { get; set; }

    }
}
