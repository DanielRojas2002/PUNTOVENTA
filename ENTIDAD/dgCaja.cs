using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgCaja
    {
        public int? Id_Venta { get; set; }
        public int? IdProducto { get; set; }



        public int? Id_Caja { get; set; }

        public int? Id_CajaEstatus { get; set; }
        public string? NombreProducto { get; set; }

        public string? DescripcionTipoVenta { get; set; }

        public string? Usuario { get; set; }

        public int? CantidadProducto { get; set; }
        public float? PrecioProducto { get; set; }
        public float? SubTotalProducto { get; set; }

        public float? CantidadTotal { get; set; }

        public float? CantidadPagada { get; set; }
        public DateTime? FechaVentaProducto { get; set; }
        public DateTime? FechaInicio { get; set; }

        public float? CantidadAbonada { get; set; }



        public float? CantidadVenta { get; set; }
        public float? CantidadRetirada { get; set; }

        public float? CantidadVA { get; set; }
        public int? IdCajaEstatus { get; set; }

        public DateTime? FechaCaja { get; set; }



    }
}
