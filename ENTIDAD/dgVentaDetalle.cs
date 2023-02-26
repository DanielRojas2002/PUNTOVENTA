using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgVentaDetalle
    {

        public int? Id_Venta { get; set; }
        public string? Id_Producto { get; set; }

      
        public string? Nombre { get; set; }
        public float? PrecioVenta { get; set; }

        public int? CantidadAComprar { get; set; }

        public int Validacion { get; set; }


    }
}
