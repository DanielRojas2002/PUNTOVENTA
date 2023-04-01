using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgCliente
    {
        public int? Id_Cliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido_Paterno { get; set; }

        public string? Apellido_Materno { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }

        public string? Estado { get; set; }

        public string? Municipio { get; set; }
        public string? Colonia { get; set; }

        public string? Calle { get; set; }

        public string? NumCasa { get; set; }
    }
}
