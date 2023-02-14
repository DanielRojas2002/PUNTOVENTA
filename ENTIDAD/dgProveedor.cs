using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgProveedor
    {
        public int? Id_Proveedor { get; set; }

        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
