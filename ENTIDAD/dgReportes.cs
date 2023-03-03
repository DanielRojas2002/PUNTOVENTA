using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgReportes
    {
        public int? Id_Venta { get; set; }
        public int? IdProducto { get; set; }
        public string? NombreProducto { get; set; }

        public string? Usuario { get; set; }
        public int? CantidadProducto { get; set; }
        public float? PrecioProducto { get; set; }
        public float? SubTotalProducto { get; set; }
        public DateTime? FechaVentaProducto { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int? Id_Compra { get; set; }
        public float? PrecioCompra { get; set; }
        public float? PrecioVenta { get; set; }
        public DateTime? FechaCompraProducto { get; set; }

    }
}
