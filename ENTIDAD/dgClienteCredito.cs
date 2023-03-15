using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgClienteCredito
    {

        public int? Id_Cliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido_Paterno { get; set; }

        public string? Apellido_Materno { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }

        public int? Id_Credito { get; set; }

     
        public int? Id_Venta { get; set; }

        public int? Id_Estatus { get; set; }

        public float CantidadPagada { get; set; }

        public float CantidadPagadaUltima { get; set; }

        public float Total { get; set; }


        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaUltimoPago { get; set; }


        public DateTime? FechaPago { get; set; }

        public int? CantidadClientes { get; set; }

        public int? CantidadCreditos { get; set; }

        public int? Validacion { get; set; }

        public float? Cambio { get; set; }
    }
}
