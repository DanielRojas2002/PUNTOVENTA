using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgCredito
    {
        public int? Id_Credito { get; set; }

        public int? Id_Cliente { get; set; }
        public int? Id_Venta { get; set; }

        public int? Id_Estatus { get; set; }


        public DateTime? FechaRegistro { get; set; }


        public DateTime? FechaPago { get; set; }
    }
}
