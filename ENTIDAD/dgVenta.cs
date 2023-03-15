using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgVenta
    {

        public int? Id_Venta { get; set; }

        public int? Id_Usuario { get; set; }


        public int? Id_Tipo_Venta { get; set; }

        public int? Stock { get; set; }

        public string? Id_Producto { get; set; }


        public int? Id_Cliente { get; set; }

      

        public string? NombreTransferencia { get; set; }
        public decimal? Total { get; set; }

        public decimal? Cambio { get; set; }

        public DateTime? FechaVenta { get; set; }

        public DateTime? FechaUltimoPago { get; set; }
    }
}
