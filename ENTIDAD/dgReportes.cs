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
        public float? PrecioProducto { get; set; }
        public float? SubTotalProducto { get; set; }
        public DateTime? FechaVentaProducto { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
