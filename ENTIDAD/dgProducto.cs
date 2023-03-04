using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTOVENTA.ENTIDAD
{
    public class dgProducto
    {
        public string? Id_Producto { get; set; }


        public int? Id_Venta { get; set; }

        public int? Id_Estatus_Producto{ get; set; }

        public int? Id_Validacion2 { get; set; }

        public int? Id_Categoria { get; set; }

        public int? Id_Medida { get; set; }

        public int? CantidadProductos { get; set; }
        public int? Id_Proveedor { get; set; }

        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public float? PrecioCompra { get; set; }
        public float? PrecioVenta { get; set; }

        public float? Iva { get; set; }


        public int? StockInicial { get; set; }

    }
}
